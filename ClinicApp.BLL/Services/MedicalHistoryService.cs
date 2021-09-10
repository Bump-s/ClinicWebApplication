using AutoMapper;
using ClinicApp.BLL.DTO;
using ClinicApp.DAL.Context.Repository;
using ClinicApp.DAL.Entities;
using ClinicApp.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace ClinicApp.BLL.Services
{
    public interface IMedicalHistoryService
    {
        public List<MedicalHistoryDTO> GetAll();
        public void Delete(Guid? id);
        public MedicalHistoryDTO Get(Guid? id);
        public void Update(MedicalHistoryDTO medicalHistoryDTO);
        public void Create(MedicalHistoryDTO medicalHistoryDTO);

    }

    public class MedicalHistoryService: IMedicalHistoryService
    {
        private readonly IRepository<MedicalHistory> _medicalHistoryRepository;
        private readonly IMapper _mapper;

        public MedicalHistoryService(
            IRepository<MedicalHistory> medicalHistoryRepository,
            IMapper mapper
            )
        {
            _medicalHistoryRepository = medicalHistoryRepository;
            _mapper = mapper;
        }

        public List<MedicalHistoryDTO> GetAll()
        {
            var medicalHistory = _medicalHistoryRepository.GetAll();
            var result = _mapper.Map<List<MedicalHistoryDTO>>(medicalHistory);
            return result;
        }

        public void Delete(Guid? id)
        {
            _medicalHistoryRepository.Delete(id);
        }

        public MedicalHistoryDTO Get(Guid? id)
        {
            var medicalHistory = _medicalHistoryRepository.Get(id);
            var result = _mapper.Map<MedicalHistoryDTO>(medicalHistory);
            return result;
        }

        public void Update(MedicalHistoryDTO medicalHistoryDTO)
        {
            var medicalHistory = _mapper.Map<MedicalHistory>(medicalHistoryDTO);
            _medicalHistoryRepository.Update(medicalHistory);
        }

        public void Create(MedicalHistoryDTO medicalHistoryDTO)
        {
            var medicalHistory = _mapper.Map<MedicalHistory>(medicalHistoryDTO);
            medicalHistory.Id = Guid.NewGuid();
            _medicalHistoryRepository.Create(medicalHistory);
        }

    }
}
