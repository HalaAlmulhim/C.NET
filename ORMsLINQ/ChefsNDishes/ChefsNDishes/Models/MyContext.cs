using Microsoft.EntityFrameworkCore;
namespace ChefsNDishes.Models
{
    public class MyContext: DbContext
    {
        public MyContext(DbContextOptions<MyContext> options):base(options){}
        public DbSet<Dish>Dishes{get;set;}
        public DbSet<Chef>Chefs{get;set;}
    }
}