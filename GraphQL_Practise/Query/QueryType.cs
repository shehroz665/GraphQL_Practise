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
                new Person() {PersonKey=6,Name="Waqas",Description="AD",Age=40},
                new Person() {PersonKey=7,Name="Shehroz Ali",Description="QWE",Age=15},
                new Person() {PersonKey=8,Name="Waqas",Description="FDG",Age=5},
                new Person() {PersonKey=9,Name="Waqas",Description="AD",Age=40},
                new Person() {PersonKey=10,Name="Waqas",Description="FDG",Age=5},
                new Person() {PersonKey=11,Name="Waqas",Description="AD",Age=40}
            };
            int offset = (paginations.pageNo - 1) * paginations.pageSize;
            return person.Skip(offset).Take(paginations.pageSize).ToList();


        }

        [UsePaging(DefaultPageSize =10,IncludeTotalCount =true)]

        public List<Person> getPaginatedPerson()
        {
            return new List<Person>()
            {
                new Person() {PersonKey=1,Name="Ali",Description="ABC",Age=25},
                new Person() {PersonKey=2,Name="Jawad",Description="DEFABC",Age=26},
                new Person() {PersonKey=3,Name="Wahab",Description="REF",Age=18},
                new Person() {PersonKey=4,Name="Shehroz Ali",Description="QWE",Age=15},
                new Person() {PersonKey=5,Name="Waqas",Description="FDG",Age=5},
                new Person() {PersonKey=6,Name="Waqas",Description="AD",Age=40}
            };

          

        }

        [UseOffsetPaging(DefaultPageSize = 10, IncludeTotalCount = true)]
        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public List<Person> getOffsetPaginatedPerson(Sorting sorting)
        {
            List<Person> person=new List<Person>()
            {
                new Person() {PersonKey=1,Name="ali",Description="ABC",Age=25},
                new Person() {PersonKey=2,Name="Jawad",Description="DEFABC",Age=26},
                new Person() {PersonKey=3,Name="Wahab",Description="REF",Age=18},
                new Person() {PersonKey=4,Name="Shehroz Ali",Description="QWE",Age=15},
                new Person() {PersonKey=5,Name="Waqas",Description="FDG",Age=5},
                new Person() {PersonKey=6,Name="Waqas",Description="AD",Age=40}
            };
            bool isAsc = string.Equals("ASC", sorting.dir, StringComparison.OrdinalIgnoreCase);
            if (sorting.col == 1)
            {
                person = isAsc ? person.OrderBy(x => x.PersonKey).ToList() : person.OrderByDescending(x => x.PersonKey).ToList();

            }
            else if (sorting.col == 2)
            {
                person = isAsc ? person.OrderBy(x => x.Name).ToList() : person.OrderByDescending(x => x.Name).ToList();
            }
            return person.ToList();



        }
    }
}
