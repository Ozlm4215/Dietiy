using Dietiy.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dietiy.Data.DataContext
{
    public class DietiyContext : DbContext
    {
        //public DietiyContext(DbContextOptions<DietiyContext> options) : base(options)

        //{ }

        public DietiyContext() : base()

        { }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Nutritionist> Nutritionists { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Food> Foods { get; set; }
    }


}
