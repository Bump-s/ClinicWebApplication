using ClinicWebApplication.Enums;
using System;
using System.Collections.Generic;

namespace ClinicWebApplication.Entities
{
    [Serializable]
    public class Doctor : User
    {
        public Position Position { get; set; }
        public Speciality Speciality { get; set; }
        public List<Appointment> Appointments { get; set; }
        public Schedule Schedule { get; set; }

    }
}
