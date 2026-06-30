using Microsoft.EntityFrameworkCore;
using MyFirstMVCApp.Models;

namespace FirstMVCWebApp.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
    }
}