using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace Inleveropdr_v2_Webapps.Models
{
    public class ProjectenTransactieDbContext:DbContext
    {
        public ProjectenTransactieDbContext(DbContextOptions<ProjectenTransactieDbContext> options) : base(options)
        { }
            public DbSet<Transaction> Transactions { get; set; }
        }
    }
