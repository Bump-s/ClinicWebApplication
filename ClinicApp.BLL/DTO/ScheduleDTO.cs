using ClinicApp.DAL.Entities;
using System;

namespace ClinicApp.BLL.DTO
{
    public class ScheduleDTO
    {
        public Guid Id { get; set; }
        public string TimeName { get; set; }
        public Guid DoctorId { get; set; }
        public DateTime BegintWorkingHour { get; set; }
        public DateTime Interval { get; set; }
        public DateTime EndWorkingHour { get; set; }
        public bool AvailableHoursForAppointment { get; set; }
    }
}
