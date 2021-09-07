using ClinicApp.BLL.DTO;
using ClinicApp.DAL.Context.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.BLL.Services
{
    public class DoctorService
    {
        private readonly DoctorRepository _doctorRepository;

        public DoctorService()
        {
            _doctorRepository = new DoctorRepository();
        }
        public List<DoctorDTO> GetAll()
        {
            var doctors = _doctorRepository.GetAll();
            return doctors.Select(doctor => new DoctorDTO
            {
                Position = doctor.Position,
                FullName = doctor.UserName,
                Email = doctor.Email,
                PhoneNumber = doctor.PhoneNumber,
                Id = doctor.Id,
                Appointments = doctor.Appointments,
                BirthDate = doctor.BirthDate,
                Speciality = doctor.Speciality,
            }).ToList();
        }

        public void Delete(Guid? id)
        {
            _doctorRepository.Delete(id);
        }
        public DoctorDTO Get(Guid? id)
        {
            var doctor = _doctorRepository.Get(id);
            return doctor.(doctor => new DoctorDTO
            {
                Position = doctor.Position,
                FullName = doctor.UserName,
                Email = doctor.Email,
                PhoneNumber = doctor.PhoneNumber,
                Id = doctor.Id,
                Appointments = doctor.Appointments,
                BirthDate = doctor.BirthDate,
                Speciality = doctor.Speciality,
            }).ToList();
        }
    }
}
