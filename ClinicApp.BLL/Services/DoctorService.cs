using AutoMapper;
using ClinicApp.BLL.DTO;
using ClinicApp.DAL.Context.Repository;
using ClinicApp.DAL.Entities;
using ClinicApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicApp.BLL.Services
{
    public interface IDoctorService
    {
        public List<DoctorDTO> GetAll();
        public void Delete(Guid? id);
        public DoctorDTO Get(Guid? id);
        public void Update(DoctorDTO doctorDTO);
        public void Create(DoctorDTO doctorDTO);
        DoctorDTO GetByEmail(string email);
    }
    public class DoctorService : IDoctorService
    {
        private readonly IRepository<Doctor> _doctorRepository;
        private readonly IMapper _mapper;

        public DoctorService(
            IRepository<Doctor> doctorRepository, 
            IMapper mapper)
        {
            _doctorRepository = doctorRepository;
            _mapper = mapper;
        }
        public List<DoctorDTO> GetAll()
        {
            var doctors = _doctorRepository.GetAll();
            var result = _mapper.Map<IEnumerable<DoctorDTO>>(doctors);
            return result.ToList();
        }

        public void Delete(Guid? id)
        {
            _doctorRepository.Delete(id);
        }

        public DoctorDTO Get(Guid? id)
        {
            var doctor = _doctorRepository.Get(id);
            var result = _mapper.Map<DoctorDTO>(doctor);
            return result;
        }

        public void Update(DoctorDTO doctorDTO)
        {
            var doctor = _mapper.Map<Doctor>(doctorDTO);
            _doctorRepository.Update(doctor);
        }

        public void Create(DoctorDTO doctorDTO)
        {
            var doctor = _mapper.Map<Doctor>(doctorDTO);
            _doctorRepository.Create(doctor);
        }

        public DoctorDTO  GetByEmail(string email)
        {
            var doctor =  _doctorRepository.GetAll().FirstOrDefault(s => s.Email.Equals(email));
            var result = _mapper.Map<DoctorDTO>(doctor);
            return result;

        }
    }
}
