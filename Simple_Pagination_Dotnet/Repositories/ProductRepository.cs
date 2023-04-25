using Microsoft.EntityFrameworkCore;
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

        public Product? Get(int Id)
        {
            return _context.Products.AsNoTracking().SingleOrDefault(x => x.Id == Id);
        }
        
        public async Task<Product?> GetAsync(int Id)
        {
            return await _context.Products.AsNoTracking().SingleOrDefaultAsync(x => x.Id == Id);
        }

        public PaginatedList<Product> GetAll(QueryParameters queryParameters)
        {
            if (!string.IsNullOrWhiteSpace(queryParameters.SearchText))
            {
                PaginatedList<Product> products = _context.Products.AsNoTracking().Where(x => x.Name.Contains(queryParameters.SearchText)).Pagination(queryParameters.PageIndex, queryParameters.PageSize);
                products.SearchText = queryParameters.SearchText;
                return products;
            }
            else return _context.Products.AsNoTracking().Pagination(queryParameters.PageIndex, queryParameters.PageSize);
        }
        
        public async Task<PaginatedList<Product>> GetAllAsync(QueryParameters queryParameters)
        {
            if (!string.IsNullOrWhiteSpace(queryParameters.SearchText))
            {
                PaginatedList<Product> products = await _context.Products.AsNoTracking().Where(x => x.Name.Contains(queryParameters.SearchText)).PaginationAsync(queryParameters.PageIndex, queryParameters.PageSize);
                products.SearchText = queryParameters.SearchText;
                return products;
            }
            else return await _context.Products.PaginationAsync(queryParameters.PageIndex, queryParameters.PageSize);
        }
    }
}