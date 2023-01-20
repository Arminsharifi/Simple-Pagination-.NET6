namespace Simple_Pagination_Dotnet.Models
{
    //You can use class instead of record without any problem
    public record Product
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}