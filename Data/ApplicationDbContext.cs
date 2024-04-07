using Microsoft.EntityFrameworkCore;
using NewApplication1.Models.Entities;

namespace NewApplication1.Data
{
    public class ApplicationDbContext : DbContext
    {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {

            }
        public DbSet<Travels> Travels { get; set; }

    }
}
