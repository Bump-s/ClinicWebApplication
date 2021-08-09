using System.Collections.Generic;

namespace ClinicApp.DAL.Entities
{
    public class MedicalHistory
    {
        internal List<Sickness> Sickness { get; set; }
        internal List<Appointment> Appointments { get; set; }
    }
}
