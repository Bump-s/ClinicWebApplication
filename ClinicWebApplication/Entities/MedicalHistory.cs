using ClinicWebApplication.Modules;
using System.Collections.Generic;

namespace ClinicWebApplication.Entities
{
    public class MedicalHistory
    {
        public List<Sickness> Sickness { get; set; }
        public List<Appointment> Appointments { get; set; }

        //public MedicalHistory()
        //{
        //    var medicalHistoryModule = new MedicalHistoryModule();
        //    medicalHistoryModule.CreateMedicalHitory()
        //}
    }
}
