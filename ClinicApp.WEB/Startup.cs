using AutoMapper;
using ClinicApp.BLL;
using ClinicApp.BLL.Services;
using ClinicApp.DAL.Context;
using ClinicApp.DAL.Context.Repository;
using ClinicApp.DAL.Entities;
using ClinicApp.DAL.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicApp.WEB
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<EfContext>(
            options => options.UseSqlServer(@"Data Source=DESKTOP-6IRIDRF\SQLEXPRESS;Initial Catalog=dbClinic;Integrated Security=True;"));

            services.AddScoped<IDoctorService, DoctorService>();
            services.AddScoped<IAppointmentService, AppointmentService>();
            services.AddScoped<IMedicalHistoryService, MedicalHistoryService>();
            services.AddScoped<IPatientService, PatientService>();
            services.AddScoped<IScheduleService, ScheduleService>();
            services.AddScoped<ISicknessService, SicknessService>();

            services.AddScoped<IRepository<Doctor>, DoctorRepository>();
            services.AddScoped<IRepository<Appointment>, AppointmentRepository>();
            services.AddScoped<IRepository<MedicalHistory>, MedicalHistoryRepository>();
            services.AddScoped<IRepository<Patient>, PatientRepository>();
            services.AddScoped<IRepository<Schedule>, ScheduleRepository>();
            services.AddScoped<IRepository<Sickness>, SicknessRepository>();

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ViewModelProfile());
                mc.AddProfile(new DTOProfile());
            });

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<EfContext>();

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            


            //IMapper mapper = MapperConfig.GetMapper();
            //services.AddSingleton(mapper);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<IdentityUser> userMngr, RoleManager<IdentityRole> roleMngr)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

             UserAndRoleDataInitializer.SeedData(userMngr, roleMngr);

            
        }
    }
}
