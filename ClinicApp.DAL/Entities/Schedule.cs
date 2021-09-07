using System;

namespace ClinicApp.DAL.Entities
{
    public class Schedule
    {
        public Guid Id { get; set; }
        public string TimeName { get; set; }
        public Doctor Doktor { get; set; }
        public DateTime BegintWorkingHour { get; set; }
        public DateTime Interval { get; set; }
        public DateTime EndWorkingHour { get; set; }
        public bool AvailableHoursForAppointment { get; set; }
    }
}
