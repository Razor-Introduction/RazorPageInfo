using Microsoft.EntityFrameworkCore;
using RazorPageInfo.Models;

namespace RazorPageInfo.DataAccess.Context
{
    public class RazorInfoContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=MONSTER\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
