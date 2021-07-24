using ClinicWebApplication.Entities;
using ClinicWebApplication.Enums;
using System;

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
    }
}
