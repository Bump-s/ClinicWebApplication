using ClinicWebApplication.Entities;
using System.Collections.Generic;

namespace ClinicWebApplication.Modules
{
    public class MedicalHistoryModule
    {
        public MedicalHistory CreateMedicalHitory()
        {
            var medicalHistory = new MedicalHistory()
            {
                Sickness = new List<Sickness>(),
                Appointments = new List<Appointment>()
            };

            return medicalHistory;
        }

        public void AddSickness(MedicalHistory medicalHistory, Sickness sickness)
        {
            medicalHistory.Sickness.Add(sickness);
        }

        public void AddAppointment(MedicalHistory medicalHistory, Appointment appointment)
        {
            medicalHistory.Appointments.Add(appointment);
        }

        public void DelSickness(MedicalHistory medicalHistory, Sickness sickness)
        {
            medicalHistory.Sickness.Remove(sickness);
        }

        public void DelAppointment(MedicalHistory medicalHistory, Appointment appointment)
        {
            medicalHistory.Appointments.Remove(appointment);
        }
    }
}
