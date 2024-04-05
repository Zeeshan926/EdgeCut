using Microsoft.EntityFrameworkCore;
using EdgeCut.Models;

namespace EdgeCut.Data
{
   
        public class ApplicationDbContext : DbContext
        {
            public DbSet<FurnitureOrder> FurnitureOrders { get; set; }
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {

            }
        }
    }

