using FirstHundredFoods.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstHundredFoods.Data
{
    public class FirstHundredFoodsContext : DbContext
    {
        public FirstHundredFoodsContext (DbContextOptions<FirstHundredFoodsContext> options)
            : base(options)
        {
        }
        
        public DbSet<Baby> Babies { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Parent> Parents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Baby>().ToTable("Baby");
            modelBuilder.Entity<Food>().ToTable("Food");
            modelBuilder.Entity<Parent>().ToTable("Parent");
        }
    }
}
