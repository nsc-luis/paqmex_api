using Microsoft.EntityFrameworkCore;

namespace PAQMEX_API
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
