using AutoMapper;
using ClinicApp.BLL.DTO;
using ClinicApp.WEB.Areas.Doctor.Models;
using ClinicApp.WEB.Models;

namespace ClinicApp.WEB
{
    public class ViewModelProfile : Profile
    {
        public ViewModelProfile()
        {
            CreateMap<DoctorViewModel, DoctorDTO>();
            CreateMap<DoctorDTO, DoctorViewModel>();

            CreateMap<PatientViewModel, PatientDTO>();
            CreateMap<PatientDTO, PatientViewModel>();

            CreateMap<AppointmentViewModel, AppointmentDTO>();
            CreateMap<AppointmentDTO, AppointmentViewModel>();

            CreateMap<MedicalHistoryViewModel, MedicalHistoryDTO>();
            CreateMap<MedicalHistoryDTO, MedicalHistoryViewModel>();

            CreateMap<ScheduleViewModel, ScheduleDTO>();
            CreateMap<ScheduleDTO, ScheduleViewModel>();

            CreateMap<SicknessViewModel, SicknessDTO>();
            CreateMap<SicknessDTO, SicknessViewModel>();

            CreateMap<RegisterViewModel, PatientDTO>();
            CreateMap<PatientDTO, RegisterViewModel>();

            CreateMap<DoctorDTO, DoctorRegisterViewModel>();
            CreateMap<DoctorRegisterViewModel, DoctorDTO>();

            
        }
    }
}
