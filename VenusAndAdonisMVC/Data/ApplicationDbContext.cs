using Microsoft.EntityFrameworkCore;
using VenusAndAdonisMVC.Models;

namespace VenusAndAdonisMVC.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
        public DbSet<ApplicationType> ApplicationType { get; set; }


    }
}
