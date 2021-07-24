using ClinicWebApplication.Entities;
using System;
using ClinicWebApplication.Enums;

namespace ClinicWebApplication.Modules
{
    public class PatientModule
    {
        public Patient CreatePatient(string fullname, DateTime birthDate, string phoneNumber, string email)
        {
            var medicalHistory = new MedicalHistory();
            var patient = new Patient()
            {
                Id = Guid.NewGuid(),
                FullName = fullname,
                BirthDate = birthDate,
                Email = email,
                PhoneNumber = phoneNumber,
                RegistrationDate = DateTime.Now,
                Role = Role.Patient,
                MedicalHistory = medicalHistory,
            };

            return patient;
        }
    }
}
