using ClinicApp.DAL.Entities;
using ClinicApp.DAL.Enums;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace ClinicApp.BLL.DTO
{
    public class DoctorDTO : PageModel
    {
        public string Id { get; set; }
        //public Role Role { get; set; }
        public string Speciality { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Position Position { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
