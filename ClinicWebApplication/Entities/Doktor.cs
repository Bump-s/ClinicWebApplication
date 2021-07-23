using ClinicWebApplication.Enums;
using System.Collections.Generic;

namespace ClinicWebApplication.Entities
{
    public class Doktor : User
    {
        public Position Position { get; set; }
        public Speciality Speciality { get; set; }

        public Doktor(Position position, Speciality speciality)
        {
            Role = Role.Doktor;
            Position = position;
            Speciality = speciality;
        }
    }
}
