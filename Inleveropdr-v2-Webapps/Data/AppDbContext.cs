using Inleveropdr_v2_Webapps.Models;
using Microsoft.EntityFrameworkCore;

namespace Inleveropdr_v2_Webapps.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> contextOptions)
            :base(contextOptions)
        {

        }
        public DbSet<Projecten> Projecten { get; set; }

    }
}
