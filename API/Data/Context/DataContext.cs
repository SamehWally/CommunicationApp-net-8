using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data.Context
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public DbSet<AppUser> Users { get; set; }
    }
}
