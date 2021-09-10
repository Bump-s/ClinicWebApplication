using ClinicApp.BLL.DTO;
using ClinicApp.DAL.Enums;
using System;
using System.Collections.Generic;

namespace ClinicApp.WEB.Models
{
    public class DoctorViewModel
    {
        public string Id { get; set; }
        public string Speciality { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Position Position { get; set; }
        public List<AppointmentDTO> Appointments { get; set; }
    }
}
