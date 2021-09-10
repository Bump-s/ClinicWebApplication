using ClinicApp.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicApp.WEB.Models
{
    public class MedicalHistoryViewModel
    {
        public Guid Id { get; set; }
        public List<SicknessDTO> Sickness { get; set; }
        public List<AppointmentDTO> Appointments { get; set; }
    }
}
