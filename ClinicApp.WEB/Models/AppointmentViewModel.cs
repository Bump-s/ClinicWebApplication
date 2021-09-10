using ClinicApp.BLL.DTO;
using ClinicApp.DAL.Enums;
using System;


namespace ClinicApp.WEB.Models
{
    public class AppointmentViewModel
    {
        public Guid Id { get; set; }
        public DoctorDTO Doctor { get; set; }
        public PatientDTO Patient { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime CreationDate { get; set; }
        public string PatientComment { get; set; }
        public AppointmentStatus AppointmentStatus { get; set; }
    }
}
