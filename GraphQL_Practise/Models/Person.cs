namespace GraphQL_Practise.Models
{
    public class Person
    {
        public int PersonKey { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int? Age { get; set; }
    }
    public class Pagination
    {
        public int pageNo { get; set; }
        public int pageSize { get; set; }
    }
}
