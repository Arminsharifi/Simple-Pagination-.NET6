using Simple_Pagination_Dotnet.Models;
using Simple_Pagination_Dotnet.Pagination;

namespace Simple_Pagination_Dotnet.Interfaces
{
    public interface IProductRepository
    {
        PaginatedList<Product> GetAll(QueryParameters queryParameters);
        Task<PaginatedList<Product>> GetAllAsync(QueryParameters queryParameters);
        Product? Get(int Id);
        Task<Product?> GetAsync(int Id);
    }
}