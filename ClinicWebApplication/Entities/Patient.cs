using System;
using ClinicWebApplication.Enums;

namespace ClinicWebApplication.Entities
{
    public class Patient : User
    {
        public DateTime RegistrationDate { get; set; }
        public Schedule Schedule { get; set; }
        public MedicalHistory MedicalHistory { get; set; }

        public Patient()
        {
            Role = Role.Patient;
            MedicalHistory = new MedicalHistory();
            RegistrationDate = DateTime.Now;
        }
    }
}
