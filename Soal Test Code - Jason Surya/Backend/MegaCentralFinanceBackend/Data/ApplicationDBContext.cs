using MegaCentralFinanceBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace MegaCentralFinanceBackend.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<ms_user> ms_user { get; set; }
        public DbSet<tr_bpkb> tr_bpkb { get; set; }
        public DbSet<ms_storage_location> ms_storage_location { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        {
            
        }
    }
}
