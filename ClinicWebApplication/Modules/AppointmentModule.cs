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

        public void CanceleAppointment(Appointment appointment)
        {
            appointment.AppointmentStatus = AppointmentStatus.Canceled;
        }

        public void CompleteAppointment(Appointment appointment)
        {
            appointment.AppointmentStatus = AppointmentStatus.Completed;
        }

    }
}
