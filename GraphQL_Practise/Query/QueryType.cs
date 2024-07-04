using GraphQL_Practise.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace GraphQL_Practise.Query
{
   
    public class QueryType
    {
        private readonly DataStore _dataStore;

        public QueryType()
        {
            _dataStore = new DataStore();
        }

        [UseOffsetPaging(DefaultPageSize =10,IncludeTotalCount=true)]
        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public List<Users> getAllUsers(Sorting sorting,string search,[Service] ApplicationDbContext _db)
        {
            var res= _db.User.ToList();
            if (!string.IsNullOrEmpty(search))
            {
             res= res.Where((x) => x.UserName.Contains(search,StringComparison.OrdinalIgnoreCase)).ToList();
            }
            if (sorting != null)
            {
                bool isAsc=string.Equals("ASC",sorting.dir,StringComparison.OrdinalIgnoreCase);
                if (sorting.col == 0)
                {
                    res = isAsc ? res.OrderBy(x => x.UserKey).ToList() : res.OrderByDescending(x => x.UserKey).ToList();
                }
                else if (sorting.col == 1)
                {
                    res= isAsc ? res.OrderBy(x=> x.UserName).ToList() : res.OrderByDescending(x=> x.UserName).ToList();
                }
                else if(sorting.col == 2) 
                {
                    res = isAsc ? res.OrderBy(x => x.UserEmail).ToList() : res.OrderByDescending(x => x.UserEmail).ToList();
                }
            }
            return res;
        }

        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public async Task<List<Person>> getPersons(Pagination paginations)
        {
            var person = await _dataStore.personStore();
            int offset = (paginations.pageNo - 1) * paginations.pageSize;
            return person.Skip(offset).Take(paginations.pageSize).ToList();
        }

        [UsePaging(DefaultPageSize =10,IncludeTotalCount =true)]

        public async Task<List<Person>> getPaginatedPerson()
        {
            return await _dataStore.personStore();
        }

        [UseOffsetPaging(DefaultPageSize = 10, IncludeTotalCount = true)]
        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public async Task<List<Person>> getOffsetPaginatedPerson(Sorting sorting)
        {
            var person =await _dataStore.personStore();
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
