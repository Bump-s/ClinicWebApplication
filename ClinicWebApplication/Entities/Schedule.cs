using System;

namespace ClinicWebApplication.Entities
{
    public class Schedule
    {
        public string TimeName { get; set; }
        public Doktor Doktor { get; set; }
        public DateTime BegintWorkingHour { get; set; }
        public DateTime Interval { get; set; }
        public DateTime EndWorkingHour { get; set; }
        public bool AvailableHoursForAppointment { get; set; }
    }
}
