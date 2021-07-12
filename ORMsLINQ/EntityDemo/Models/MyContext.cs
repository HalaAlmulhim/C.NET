using Microsoft.EntityFrameworkCore;

namespace EntityDemo.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options){}
        public DbSet<User> Users{get;set;}
    }
}