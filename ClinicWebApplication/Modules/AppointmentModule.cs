using ClinicWebApplication.Entities;
using ClinicWebApplication.Enums;
using System;

namespace ClinicWebApplication.Modules
{
    public class AppointmentModule
    {
        public Appointment CreateAppointment(Patient patient, Doktor doktor, DateTime dateTime, string comment = "")
        {
            var appointment = new Appointment()
            {
                Id = Guid.NewGuid(),
                AppointmentStatus = AppointmentStatus.Open,
                AppointmentDate = dateTime,
                CreationDate = DateTime.Now,
                Doktor = doktor,
                Patient = patient,
                PatientComment = comment
            };

            return appointment;
        }

        public void DeleteAppointment(Appointment appointment)
        {
        }

        public void ReadAppointment(Appointment appointment)
        {

        }

        public Appointment UpdateAppointment(Appointment appointment)
        {
            throw new NotImplementedException();
        }
    }
}
