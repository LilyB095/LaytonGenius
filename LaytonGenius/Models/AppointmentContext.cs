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
    }
}