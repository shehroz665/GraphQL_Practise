using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace GraphQL_Practise.Models
{
    public class ApplicationDbContext : DbContext
    {
        private readonly DataStore _dataStore;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            _dataStore = new DataStore();
        }

        public DbSet<Users> User { get; set; }
        public DbSet<Products> Product { get; set; }
        public DbSet<Categorys> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Users>().HasData(_dataStore.userStore());

            modelBuilder.Entity<Categorys>().HasData(_dataStore.categoryStore());

            modelBuilder.Entity<Products>().HasData(_dataStore.productStore());
        }

    }
}
