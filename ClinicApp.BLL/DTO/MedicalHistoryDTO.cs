using ClinicApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.BLL.DTO
{
    public class MedicalHistoryDTO
    {
        public Guid Id { get; set; }
        internal List<Sickness> Sickness { get; set; }
        internal List<Appointment> Appointments { get; set; }
    }
}
