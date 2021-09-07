using System;
using System.Collections.Generic;

namespace ClinicApp.DAL.Entities
{
    public class MedicalHistory
    {
        public Guid Id{ get; set; }
        internal List<Sickness> Sickness { get; set; }
        internal List<Appointment> Appointments { get; set; }
    }
}
