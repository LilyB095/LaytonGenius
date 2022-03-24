using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace LaytonGenius.Models
{
    public class AppointmentContext : DbContext
    {
        //Constructor
        public AppointmentContext(DbContextOptions<AppointmentContext> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Available> AvailableTimes { get; set; }


        //Seed Data
        protected override void OnModelCreating (ModelBuilder mb)
        {
            //number of available times!
            mb.Entity<Available>().HasData(
                new Available
                { DateID = 1, Date = new DateTime(2022, 03, 23, 08, 00, 00) },
                new Available
                { DateID = 2, Date = new DateTime(2022, 03, 23, 09, 00, 00) },
                new Available
                { DateID = 3, Date = new DateTime(2022, 03, 23, 10, 00, 00) },
                new Available
                { DateID = 4, Date = new DateTime(2022, 03, 23, 11, 00, 00) },
                new Available
                { DateID = 5, Date = new DateTime(2022, 03, 23, 12, 00, 00) },
                new Available
                { DateID = 6, Date = new DateTime(2022, 03, 23, 13, 00, 00) },
                new Available
                { DateID = 7, Date = new DateTime(2022, 03, 23, 14, 00, 00) },
                new Available
                { DateID = 8, Date = new DateTime(2022, 03, 23, 15, 00, 00) },
                new Available
                { DateID = 9, Date = new DateTime(2022, 03, 23, 16, 00, 00) },
                new Available
                { DateID = 10, Date = new DateTime(2022, 03, 23, 17, 00, 00) },
                new Available
                { DateID = 11, Date = new DateTime(2022, 03, 23, 18, 00, 00) },
                new Available
                { DateID = 12, Date = new DateTime(2022, 03, 23, 19, 00, 00) },
                new Available
                { DateID = 13, Date = new DateTime(2022, 03, 23, 20, 00, 00) }
                );
        }


    }
}