using BloodDonationManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonationManagementSystem.Data_Access
{
    public class DonarContext : DbContext
    {
        public DonarContext(DbContextOptions options): base(options)
        {

        }


        public DbSet<SchoolModel> schoolModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SchoolModel>().HasData(new SchoolModel
            {
                DonarId = 1,
                DonarName = "Pavan",
                DonarCity = "Davangere",
                DonarAddress = "Anjaneya Badavane"

            });

        }
    }
}
