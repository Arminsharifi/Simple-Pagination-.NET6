namespace Simple_Pagination_Dotnet.Pagination
{
    public class QueryParameters
    {
        public int PageSize { get; set; } = 4;
        public int PageIndex { get; set; } = 1;
        public string SearchText { get; set; } = string.Empty;
    }
}