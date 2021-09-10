using AutoMapper;
using ClinicApp.BLL.DTO;
using ClinicApp.DAL.Entities;


namespace ClinicApp.BLL
{
    public class DTOProfile : Profile
    {
        public DTOProfile()
        {
            CreateMap<Doctor, DoctorDTO>();
            CreateMap<DoctorDTO, Doctor>();

            CreateMap<Patient, PatientDTO>();
            CreateMap<PatientDTO, Patient>();

            CreateMap<Appointment, AppointmentDTO>();
            CreateMap<AppointmentDTO, Appointment>();

            CreateMap<MedicalHistory, MedicalHistoryDTO>();
            CreateMap<MedicalHistoryDTO, MedicalHistory>();

            CreateMap<Schedule, ScheduleDTO>();
            CreateMap<ScheduleDTO, Schedule>();

            CreateMap<Sickness, SicknessDTO>();
            CreateMap<SicknessDTO, Sickness>();

            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }

    }
}
