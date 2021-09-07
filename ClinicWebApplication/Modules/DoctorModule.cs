using ClinicWebApplication.Entities;
using ClinicWebApplication.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClinicWebApplication.Modules
{
    class DoctorModule
    {
        public Doctor CreateDoctor(string fullname, DateTime birthDate, string phoneNumber,
            string email, Position position, Speciality speciality)
        {
            var doktor = new Doctor()
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

        public void AddShedule(Doctor doktor)
        {
            var scheduleModule = new ScheduleModule();
            doktor.Schedule = scheduleModule.GenerateSchedule();
        }

        public void AddAppointment(Doctor doktor, Appointment appointment)
        {
            doktor.Appointments.Add(appointment);
        }

        public Doctor GetDoctorByName(string name, string path)
        {
            var jsonModule = new JsonModule();
            List<Doctor> doktors = jsonModule.ReadJson<List<Doctor>>(path);

            var selectedDoctor = doktors.FirstOrDefault(s => s.FullName.Equals(name));

            return selectedDoctor;
        }

        public IEnumerable<IGrouping<Speciality, Doctor>> GroupDoktorsBySpeciality(string path)
        {
            var jsonModule = new JsonModule();
            List<Doctor> doktors = jsonModule.ReadJson<List<Doctor>>(path);

            var doktorGroups = doktors.GroupBy(d => d.Speciality);

            return doktorGroups;
        }

        public IEnumerable<Doctor> GetDoktorsWithSpeciality(string path, Speciality speciality)
        {
            var jsonModule = new JsonModule();
            List<Doctor> doktors = jsonModule.ReadJson<List<Doctor>>(path);

            var selectedDoktors = doktors.Where(d => d.Speciality.Equals(speciality));

            return selectedDoktors;
        }
    }
}
