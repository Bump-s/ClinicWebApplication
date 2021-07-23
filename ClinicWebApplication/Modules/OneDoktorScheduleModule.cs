using ClinicWebApplication.Entities;
using System;

namespace ClinicWebApplication.Modules
{
    public class OneDoktorScheduleModule
    {
        public string TimeName { get; set; }
        public Doktor Doktor { get; set; }
        public DateTime BegintWorkingHour { get; set; }
        public DateTime Interval { get; set; }
        public DateTime EndWorkingHour { get; set; }
        public bool AvailableHoursForAppointment { get; set; }

        public OneDoktorScheduleModule()
        {
            GenerateSchedule();
        }
        public OneDoktorScheduleModule(string timeName, Doktor doktor, DateTime begin, DateTime end, bool isUse)
        {
            Doktor = doktor;
            Interval = begin + new TimeSpan(0, 30, 0);
            TimeName = timeName;
            BegintWorkingHour = begin;
            EndWorkingHour = end;
            AvailableHoursForAppointment = isUse;
            GenerateSchedule();
        }

        public Schedule GenerateSchedule()
        {
            var oneDoctorSchedule = new OneDoktorScheduleModule();
            var schedule = new Schedule();

            schedule.GeneretedShcedule.Add(oneDoctorSchedule);

            return schedule;
        }

    }
}
