using ClinicWebApplication.Entities;
using ClinicWebApplication.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClinicWebApplication.Modules
{
    class DoktorModule
    {
        public Doktor CreateDoktor(string fullname, DateTime birthDate, string phoneNumber,
            string email, Position position, Speciality speciality)
        {
            var doktor = new Doktor()
            {
                Id = Guid.NewGuid(),
                FullName = fullname,
                BirthDate = birthDate,
                Email = email,
                PhoneNumber = phoneNumber,
                Role = Role.Doktor,
                Speciality = speciality,
                Position = position,
            };

            return doktor;
        }

        public void AddShedule(Doktor doktor)
        {
            var scheduleModule = new ScheduleModule();
            doktor.Schedule = scheduleModule.GenerateSchedule();
        }

        public void AddAppointment(Doktor doktor, Appointment appointment)
        {
            doktor.Appointments.Add(appointment);
        }

        public Doktor GetDoktorByName(string name, string path)
        {
            var jsonModule = new JsonModule();
            List<Doktor> doktors = jsonModule.ReadJson<List<Doktor>>(path);

            var selectedDoktor = doktors.FirstOrDefault(s => s.FullName.Equals(name));

            return selectedDoktor;
        }

        public IEnumerable<IGrouping<Speciality, Doktor>> GroupDoktorsBySpeciality(string path)
        {
            var jsonModule = new JsonModule();
            List<Doktor> doktors = jsonModule.ReadJson<List<Doktor>>(path);

            var doktorGroups = doktors.GroupBy(d => d.Speciality);

            return doktorGroups;
        }

        public IEnumerable<Doktor> GetDoktorsWithSpeciality(string path, Speciality speciality)
        {
            var jsonModule = new JsonModule();
            List<Doktor> doktors = jsonModule.ReadJson<List<Doktor>>(path);

            var selectedDoktors = doktors.Where(d => d.Speciality.Equals(speciality));

            return selectedDoktors;
        }
    }
}
