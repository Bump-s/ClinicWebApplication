using ClinicWebApplication.Enums;
using System.Collections.Generic;

namespace ClinicWebApplication.Entities
{
    public class Doktor : User
    {
        public Position Position { get; set; }
        public Speciality Speciality { get; set; }
        public List<Appointment> Appointments { get; set; }
        public Schedule Schedule { get; set; }

    }
}
