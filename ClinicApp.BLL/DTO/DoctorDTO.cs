using ClinicApp.DAL.Entities;
using ClinicApp.DAL.Enums;
using System;
using System.Collections.Generic;

namespace ClinicApp.BLL.DTO
{
    public class DoctorDTO
    {
        public Guid Id { get; set; }
        public string Speciality { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Position Position { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
