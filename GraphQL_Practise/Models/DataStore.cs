namespace GraphQL_Practise.Models
{
    [Obsolete]
    public class DataStore
    {
        public List<Users> userStore()
        {
            return new List<Users>()
            {
            new Users { UserKey=1,UserName="Shehroz Ali",UserEmail="shehrozmalik665@gmail.com",CreatedOn=DateTime.Now,UpdatedOn=DateTime.Now},
            new Users { UserKey = 2, UserName = "Ali", UserEmail = "ali@gmail.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Users { UserKey = 3, UserName = "Jawad", UserEmail = "jawad@gmail.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Users { UserKey = 4, UserName = "Wahab", UserEmail = "wahab@gmail.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Users { UserKey = 5, UserName = "Waqas", UserEmail = "waqas@gmail.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Users { UserKey = 6, UserName = "Hassan", UserEmail = "hassan@gmail.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Users { UserKey = 7, UserName = "Usman", UserEmail = "usman@gmail.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Users { UserKey = 8, UserName = "Ahmad", UserEmail = "ahmad@gmail.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Users { UserKey = 9, UserName = "Bilal", UserEmail = "bilal@gmail.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Users { UserKey = 10, UserName = "Noman", UserEmail = "noman@gmail.com", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now }
            };
        }

        public List<Categorys> categoryStore()
        {
            return new List<Categorys>()
            {
            new Categorys { CategoryKey = 1, CategoryName = "Bags", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Categorys { CategoryKey = 2, CategoryName = "Shoes", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Categorys { CategoryKey = 3, CategoryName = "Clothing", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Categorys { CategoryKey = 4, CategoryName = "Accessories", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Categorys { CategoryKey = 5, CategoryName = "Electronics", CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now }
            };
        }
        public List<Products> productStore()
        {
            return new List<Products>()
            {
         new Products { ProductId = 1, Name = "School Bag", CategoryKey = 1, Description = null, CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Products { ProductId = 2, Name = "Running Shoes", CategoryKey = 2, Description = null, CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Products { ProductId = 3, Name = "T-Shirt", CategoryKey = 3, Description = null, CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Products { ProductId = 4, Name = "Leather Belt", CategoryKey = 4, Description = null, CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Products { ProductId = 5, Name = "Smartphone", CategoryKey = 5, Description = null, CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Products { ProductId = 6, Name = "Laptop Bag", CategoryKey = 1, Description = null, CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Products { ProductId = 7, Name = "Sandals", CategoryKey = 2, Description = null, CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Products { ProductId = 8, Name = "Jacket", CategoryKey = 3, Description = null, CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Products { ProductId = 9, Name = "Watch", CategoryKey = 4, Description = null, CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Products { ProductId = 10, Name = "Tablet", CategoryKey = 5, Description = null, CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Products { ProductId = 11, Name = "Travel Bag", CategoryKey = 1, Description = null, CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Products { ProductId = 12, Name = "Formal Shoes", CategoryKey = 2, Description = null, CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Products { ProductId = 13, Name = "Jeans", CategoryKey = 3, Description = null, CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Products { ProductId = 14, Name = "Necklace", CategoryKey = 4, Description = null, CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now },
            new Products { ProductId = 15, Name = "Headphones", CategoryKey = 5, Description = null, CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now }
            };
        }
    }
}
