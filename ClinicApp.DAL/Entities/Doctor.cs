using ClinicApp.DAL.Enums;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;

namespace ClinicApp.DAL.Entities
{
    public class Doctor : User
    {
        public Position Position { get; set; }
        public string Speciality { get; set; }
        public List<Appointment> Appointments { get; set; }
        

    }
}
