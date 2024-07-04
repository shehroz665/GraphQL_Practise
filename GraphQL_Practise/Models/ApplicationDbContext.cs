using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace GraphQL_Practise.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Users> User { get; set; }
        public DbSet<Products> Product { get; set; }
        public DbSet<Categorys> Category { get; set; }

    }
}
