using System.ComponentModel.DataAnnotations;

namespace Simple_Pagination_Dotnet.Pagination
{
    public class QueryParameters
    {
        [Range(0,int.MaxValue)]
        public int PageSize { get; set; } = 4;
        [Range(0,int.MaxValue)]
        public int PageIndex { get; set; } = 1;
        public string SearchText { get; set; } = string.Empty;
    }
}