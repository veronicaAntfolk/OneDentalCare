using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OneDentalCare.Models
{
    public class OneDentalCareContext : DbContext
    {
        public OneDentalCareContext (DbContextOptions<OneDentalCareContext> options)
            : base(options)
        {
        }

        public DbSet<OneDentalCare.Models.Patient> Patient { get; set; }
    }
}
