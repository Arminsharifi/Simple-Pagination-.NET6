using Simple_Pagination_Dotnet.Context;
using Simple_Pagination_Dotnet.Interfaces;
using Simple_Pagination_Dotnet.Models;
using Simple_Pagination_Dotnet.Pagination;

namespace Simple_Pagination_Dotnet.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;

        public ProductRepository(ProductContext context)
        {
            this._context = context;
        }

        public Product Get(int Id)
        {
            return _context.Products.FirstOrDefault(x => x.Id == Id);
        }

        public PaginatedList<Product> GetAll(QueryParameters queryParameters)
        {
            if (!string.IsNullOrWhiteSpace(queryParameters.SearchText))
            {
                PaginatedList<Product> products = _context.Products.Where(x => x.Name.Contains(queryParameters.SearchText)).Pagination(queryParameters.PageIndex, queryParameters.PageSize);
                products.SearchText = queryParameters.SearchText;
                return products;
            }
            else return _context.Products.Pagination(queryParameters.PageIndex, queryParameters.PageSize);
        }
    }
}