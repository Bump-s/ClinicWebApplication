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

        public MedicalHistory AddSicknessToMedicalHistory(MedicalHistory medicalHistory, Sickness sickness)
        {
            medicalHistory.Sickness.Add(sickness);

            return medicalHistory;
        }

        public MedicalHistory AddAppointmentFromMedicalHistory(MedicalHistory medicalHistory, Appointment appointment)
        {
            medicalHistory.Appointments.Add(appointment);

            return medicalHistory;
        }

        public MedicalHistory DelSicknessToMedicalHistory(MedicalHistory medicalHistory, Sickness sickness)
        {
            medicalHistory.Sickness.Remove(sickness);

            return medicalHistory;
        }

        public MedicalHistory DelAppointmentFromMedicalHistory(MedicalHistory medicalHistory, Appointment appointment)
        {
            medicalHistory.Appointments.Remove(appointment);

            return medicalHistory;
        }
    }
}
