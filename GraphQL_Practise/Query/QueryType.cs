using GraphQL_Practise.Models;

namespace GraphQL_Practise.Query
{
    public class QueryType
    {
        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public List<Person> getPersons(Pagination paginations)
        {
            List<Person> person= new List<Person>()
            {
                new Person() {PersonKey=1,Name="Ali",Description="ABC",Age=25},
                new Person() {PersonKey=2,Name="Jawad",Description="DEFABC",Age=26},
                new Person() {PersonKey=3,Name="Wahab",Description="REF",Age=18},
                new Person() {PersonKey=4,Name="Shehroz Ali",Description="QWE",Age=15},
                new Person() {PersonKey=5,Name="Waqas",Description="FDG",Age=5},
                new Person() {PersonKey=6,Name="Waqas",Description="AD",Age=40}
            };

            return person.Skip((paginations.pageNo - 1)*paginations.pageSize).Take(paginations.pageSize).ToList();


        }
    }
}
