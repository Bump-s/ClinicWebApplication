using AutoMapper;
using ClinicApp.BLL.DTO;
using ClinicApp.DAL.Context.Repository;
using ClinicApp.DAL.Entities;
using ClinicApp.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace ClinicApp.BLL.Services
{
    public interface ISicknessService
    {
        public List<SicknessDTO> GetAll();
        public void Delete(Guid? id);
        public SicknessDTO Get(Guid? id);
        public void Create(SicknessDTO sicknessDTO);
        public void Update(SicknessDTO sicknessDTO);
    }
    public class SicknessService : ISicknessService
    {
        private readonly IRepository<Sickness> _sicknessRepository;
        private readonly IMapper _mapper;

        public SicknessService(
            IRepository<Sickness> sicknessRepository,
            IMapper mapper)
        {
            _sicknessRepository = sicknessRepository;
            _mapper = mapper;
        }
        public List<SicknessDTO> GetAll()
        {
            var sicknesses = _sicknessRepository.GetAll();
            var result = _mapper.Map<List<SicknessDTO>>(sicknesses);
            return result;
        }

        public void Delete(Guid? id)
        {
            _sicknessRepository.Delete(id);
        }

        public SicknessDTO Get(Guid? id)
        {
            var sickness = _sicknessRepository.Get(id);
            var result = _mapper.Map<SicknessDTO>(sickness);
            return result;
        }

        public void Update(SicknessDTO sicknessDTO)
        {
            var sickness = _mapper.Map<Sickness>(sicknessDTO);
            _sicknessRepository.Update(sickness);
        }

        public void Create(SicknessDTO sicknessDTO)
        {
            var sickness = _mapper.Map<Sickness>(sicknessDTO);
            sickness.Id = Guid.NewGuid();
            _sicknessRepository.Create(sickness);
        }
    }
}
