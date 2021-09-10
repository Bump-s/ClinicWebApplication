using AutoMapper;
using ClinicApp.BLL.DTO;
using ClinicApp.DAL.Context.Repository;
using ClinicApp.DAL.Entities;
using ClinicApp.DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicApp.BLL.Services
{
    public interface IPatientService
    {
        public List<PatientDTO> GetAll();
        public void Delete(Guid? id);
        public PatientDTO Get(Guid? id);
        public void Update(PatientDTO patientDTO);
        public void Create(PatientDTO patientDTO);

    }

    public class PatientService : IPatientService
    {
        private readonly IRepository<Patient> _patientRepository;
        private readonly IMapper _mapper;

        public PatientService(
            IRepository<Patient> patientRepository,
            IMapper mapper
            )
        {
            _patientRepository = patientRepository;
            _mapper = mapper;
        }
        public List<PatientDTO> GetAll()
        {
            var patients = _patientRepository.GetAll();
            var result = _mapper.Map<List<PatientDTO>>(patients);
            return result;
        }

        public void Delete(Guid? id)
        {
            _patientRepository.Delete(id);
        }

        public PatientDTO Get(Guid? id)
        {
            var patient = _patientRepository.Get(id);
            var result = _mapper.Map<PatientDTO>(patient);
            return result;
        }

        public void Update(PatientDTO patientDTO)
        {
            var patient = _mapper.Map<Patient>(patientDTO);
            _patientRepository.Update(patient);
        }

        public void Create(PatientDTO patientDTO)
        {
            var patient = _mapper.Map<Patient>(patientDTO);
           // patient.IdentityUserId = patientDTO.Id;
            _patientRepository.Create(patient);

        }

    }
}
