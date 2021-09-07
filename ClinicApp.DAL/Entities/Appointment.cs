using ClinicApp.DAL.Enums;
using System;

namespace ClinicApp.DAL.Entities
{
    public class Appointment
    {
        public Guid Id { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime CreationDate { get; set; }
        public string PatientComment { get; set; }
        public AppointmentStatus AppointmentStatus { get; set; }
    }
}
