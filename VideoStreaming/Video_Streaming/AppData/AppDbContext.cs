using Microsoft.EntityFrameworkCore;
using Video_Streaming.Models;

namespace Video_Streaming.AppData
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
