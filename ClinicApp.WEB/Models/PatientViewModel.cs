using ClinicApp.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicApp.WEB.Models
{
    public class PatientViewModel
    {
        public string Id { get; set; }
        //public Role Role { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public MedicalHistoryDTO MedicalHistory { get; set; }
        public List<AppointmentDTO> Appointments { get; set; }
        public List<ScheduleDTO> Schedules { get; set; }
    }
}
