using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;

namespace ClinicApp.DAL.Entities
{
    public class Patient : User
    {
        public DateTime RegistrationDate { get; set; }
        public MedicalHistory MedicalHistory { get; set; }
        public List<Appointment> Appointments { get; set; }
        public List<Schedule> Schedules { get; set; }
    }
}
