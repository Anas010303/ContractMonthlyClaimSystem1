using Microsoft.EntityFrameworkCore;
using ContractMonthlyClaimSystem.Models;
using System.Data.Entity;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace ContractMonthlyClaimSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public System.Data.Entity.DbSet<Claim> Claims { get; set; }
     
    }
}
