using ClinicApp.BLL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicApp.WEB.Models
{
    public class ScheduleViewModel
    {
        public string TimeName { get; set; }
        public Guid DoktorId { get; set; }
        public DateTime BegintWorkingHour { get; set; }
        public DateTime Interval { get; set; }
        public DateTime EndWorkingHour { get; set; }
        public bool AvailableHoursForAppointment { get; set; }
        public List<string> Emails { get; set; }
        public string SelectedEmail { get; set; }
    }
}
