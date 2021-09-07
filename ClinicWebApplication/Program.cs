using ClinicWebApplication.Entities;
using ClinicWebApplication.Modules;
using ClinicWebApplication.Enums;
using System;
using System.Collections.Generic;

namespace ClinicWebApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = "Doktors.json";
            string path2 = "Patient.json";

            var doktor1 = new Doctor() { Id = Guid.NewGuid(), FullName = "Andrey Evgenievich", Speciality = Speciality.Test };
            var doktor2 = new Doctor() { Id = Guid.NewGuid(), FullName = "Valeriy Antonov", Speciality = Speciality.Test1 };
            var doktor3 = new Doctor() { Id = Guid.NewGuid(), FullName = "Viktor Pozdnyazkov", Speciality = Speciality.Test1 };
            var doktor4 = new Doctor() { Id = Guid.NewGuid(), FullName = "Mariya Besedina", Speciality = Speciality.Test1 };

            var patient1 = new Patient() { Id = Guid.NewGuid(), FullName = "Georgiy Aleksandrovich", };
            var patient2 = new Patient() { Id = Guid.NewGuid(), FullName = "Alla Semenovna", };
            var patient3 = new Patient() { Id = Guid.NewGuid(), FullName = "Dmitriy Koshelev", };
            var patient4 = new Patient() { Id = Guid.NewGuid(), FullName = "Ruslan Dinisov", };

            var patients = new List<Patient>() { patient1, patient2, patient3, patient4 };
            var doktors = new List<Doctor>() { doktor1, doktor2, doktor3, doktor4 };

            var jsonModule = new JsonModule();

            jsonModule.WriteJson<List<Doctor>>(doktors, path1);
            jsonModule.WriteJson<List<Patient>>(patients, path2);
        }
    }
}
