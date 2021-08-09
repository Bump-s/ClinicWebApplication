using ClinicWebApplication.Entities;
using System;
using ClinicWebApplication.Enums;
using System.Collections.Generic;
using System.Linq;

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


        public Patient GetPatientByName(string name, string path)
        {
            var jsonModule = new JsonModule();
            List<Patient> patients = jsonModule.ReadJson<List<Patient>>(path);

            var selectedPatient = patients.FirstOrDefault(s => s.FullName.Equals(name));

            return selectedPatient;
        }

        public void SortPatientByRegistrationDate(string path)
        {
            var jsonModule = new JsonModule();
            List<Patient> patients = jsonModule.ReadJson<List<Patient>>(path);

            var sortedPatients = patients.OrderBy(p => p.RegistrationDate);
        }

        public IEnumerable<Patient> GetPatientsWithSickness(string path, Sickness sickness)
        {
            var jsonModule = new JsonModule();
            List<Patient> patients = jsonModule.ReadJson<List<Patient>>(path);

            var selectedPatients = patients.SelectMany(p => p.MedicalHistory.Sickness, (p, s) => new { Patient = p, Sickness = s })
                                                            .Where(p => p.Sickness.SicknessName == sickness.SicknessName)
                                                            .Select(p => p.Patient);

            return selectedPatients;
        }
    }
}
