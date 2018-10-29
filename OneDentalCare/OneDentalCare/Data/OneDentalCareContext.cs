using Microsoft.EntityFrameworkCore;

namespace OneDentalCare.Models
{
    public class OneDentalCareContext : DbContext
    {
        public OneDentalCareContext (DbContextOptions<OneDentalCareContext> options)
            : base(options)
        {
        }

        public DbSet<Patient> Patient { get; set; }
        public DbSet<Login> Logins { get; set; }
    }
}
