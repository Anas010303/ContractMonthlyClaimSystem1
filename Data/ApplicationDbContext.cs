using Microsoft.EntityFrameworkCore;
using ContractMonthlyClaimSystem.Models;


namespace ContractMonthlyClaimSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public System.Data.Entity.DbSet<Claim> Claims { get; set; }
        public System.Data.Entity.DbSet<Lecturer> Lecturers { get; set; }

    }
}
