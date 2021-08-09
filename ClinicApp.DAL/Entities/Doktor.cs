using ClinicApp.DAL.Enums;
using System;
using System.Collections.Generic;

namespace ClinicApp.DAL.Entities
{
    [Serializable]
    public class Doktor : User
    {
        public Position Position { get; set; }
        public Speciality Speciality { get; set; }
        public List<Appointment> Appointments { get; set; }
        public Schedule Schedule { get; set; }

    }
}
