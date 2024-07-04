using GraphQL_Practise.Models;

namespace GraphQL_Practise.Query
{
    public class PersonInfo
    {
        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public List<Person> getPersonsInfo()
        {
            return new List<Person>()
            {
                new Person() {PersonKey=1,Name="Ali",Description="ABC",Age=25},
                new Person() {PersonKey=2,Name="Jawad",Description="ABC",Age=26},
                new Person() {PersonKey=3,Name="Wahab",Description="ABC",Age=18},
                new Person() {PersonKey=4,Name="Shehroz Ali",Description="ABC",Age=15},
                new Person() {PersonKey=5,Name="Waqas",Description="ABC",Age=5},
                new Person() {PersonKey=6,Name="Waqas",Description="ABC",Age=40}
            };
        }
    }
}
