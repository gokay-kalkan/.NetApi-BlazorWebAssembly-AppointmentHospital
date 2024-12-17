using AppointmentHospital.Shared;
using Microsoft.EntityFrameworkCore;

namespace AppointmentHospital.Api.Context
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Meet> Meets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Policlinic> Policlinics { get; set; }
    }
}
