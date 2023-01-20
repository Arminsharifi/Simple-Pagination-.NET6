namespace Simple_Pagination_Dotnet.Pagination
{
    public static class PaginationExtension
    {
        public static PaginatedList<T> Pagination<T>(this IQueryable<T> source, int pageIndex, int pageSize) => new PaginatedList<T>(source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList(), source.Count(), pageIndex, pageSize);
    }
}
