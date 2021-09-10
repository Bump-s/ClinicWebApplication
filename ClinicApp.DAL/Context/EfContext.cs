using Microsoft.EntityFrameworkCore;
using ClinicApp.DAL.Entities;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Identity;

namespace ClinicApp.DAL.Context
{
    public class EfContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors{ get; set; }
        public DbSet<MedicalHistory> MedicalHistories{ get; set; }
        public DbSet<Patient> Patients{ get; set; }
        public DbSet<Schedule> Schedules{ get; set; }
        public DbSet<Sickness> Sicknesses{ get; set; }

        public EfContext(DbContextOptions<EfContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            //string ADMIN_ID = "12174cf0–9412–4cfe-afbf-59f706d72cf6";
            //string ROLE_ID = "341743f0-asd2–42de-afbf-59kmkkmk72cf6";

            ////seed admin role
            //builder.Entity<IdentityRole>().HasData(new IdentityRole
            //{
            //    Name = "Admin",
            //    NormalizedName = "ADMIN",
            //    Id = ROLE_ID,
            //    ConcurrencyStamp = ROLE_ID
            //});

            ////create user
            //var appUser = new IdentityUser
            //{
            //    Id = ADMIN_ID,
            //    Email = "admin1@gmail.com",
            //    EmailConfirmed = true,
            //    UserName = "admin1@gmail.com",
            //    NormalizedUserName = "ADMIN1@GMAIL.COM"
            //};

            ////set user password
            //PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            //appUser.PasswordHash = ph.HashPassword(appUser, "Admin1111!");

            ////seed user
            //builder.Entity<IdentityUser>().HasData(appUser);

            ////set user role to admin
            //builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            //{
            //    RoleId = ROLE_ID,
            //    UserId = ADMIN_ID
            //});
            base.OnModelCreating(builder);
        }
    }
}
