using System;
using System.Collections.Generic;
using ClinicWebApplication.Enums;

namespace ClinicWebApplication.Entities
{
    public class Patient : User
    {
        public DateTime RegistrationDate { get; set; }
        public MedicalHistory MedicalHistory { get; set; }
        public List<Appointment> Appointments { get; set; }
        public List<Schedule> Schedules { get; set; }

        public Patient()
        {
            Role = Role.Patient;
            MedicalHistory = new MedicalHistory();
            RegistrationDate = DateTime.Now;
        }
    }
}
