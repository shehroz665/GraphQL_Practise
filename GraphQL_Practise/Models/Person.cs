namespace GraphQL_Practise.Models
{
    [Obsolete]
    public class Person
    {
        public int PersonKey { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int? Age { get; set; }
    }
    [Obsolete]
    public class Pagination
    {
        public int pageNo { get; set; }
        public int pageSize { get; set; }
    }
    [Obsolete]
    public class Sorting
    {
        public string dir { get; set; }
        public int col { get; set; }
    }
}
