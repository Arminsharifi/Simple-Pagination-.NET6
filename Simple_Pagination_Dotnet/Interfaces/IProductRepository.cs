using Simple_Pagination_Dotnet.Models;
using Simple_Pagination_Dotnet.Pagination;

namespace Simple_Pagination_Dotnet.Interfaces
{
    public interface IProductRepository
    {
        PaginatedList<Product> GetAll(QueryParameters queryParameters);
        Product Get(int Id);
    }
}