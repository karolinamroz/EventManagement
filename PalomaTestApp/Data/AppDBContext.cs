using Microsoft.EntityFrameworkCore;
using PalomaTestApp.Models;

namespace PalomaTestApp.Data
{
    public class AppDBContext :DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) 
        {

        }

        public DbSet<Event> Events { get; set; }
    }
}
