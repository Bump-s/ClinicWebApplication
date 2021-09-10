using ClinicApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.BLL.DTO
{
    public class PatientDTO
    {
        public string Id { get; set; }
        //public Role Role { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public MedicalHistory MedicalHistory { get; set; }
        public List<Appointment> Appointments { get; set; }
        public List<Schedule> Schedules { get; set; }
        public string Password { get; set; }
    }
}
