using Microsoft.EntityFrameworkCore;
using ClinicApp.DAL.Entities;
using Microsoft.EntityFrameworkCore.Design;

namespace ClinicApp.DAL.Context
{
    public class EfContext : DbContext
    {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors{ get; set; }
        public DbSet<MedicalHistory> MedicalHistories{ get; set; }
        public DbSet<Patient> Patients{ get; set; }
        public DbSet<Schedule> Schedules{ get; set; }
        public DbSet<Sickness> Sicknesses{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-6IRIDRF\SQLEXPRESS;Initial Catalog=dbClinic;Integrated Security=True;");
        }
    }
}
