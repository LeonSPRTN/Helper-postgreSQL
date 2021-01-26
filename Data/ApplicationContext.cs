using Helper_postgreSQL.Models;
using System.Data.Entity;

namespace Helper_postgreSQL.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Setting> Settings { get; set; }
        public ApplicationContext() : base("DefaultConnection")
        {
        }      
    }
}