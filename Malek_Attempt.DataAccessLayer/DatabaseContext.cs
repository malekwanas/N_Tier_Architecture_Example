using Malek_Attempt.Models;
using Microsoft.EntityFrameworkCore;

namespace Malek_Attempt.DataAccessLayer
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
    }
}
