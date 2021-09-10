using AutoMapper;
using ClinicApp.BLL.DTO;
using ClinicApp.DAL.Context.Repository;
using ClinicApp.DAL.Entities;
using ClinicApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.BLL.Services
{
    public interface IScheduleService
    {
        public List<ScheduleDTO> GetAll();
        public void Delete(Guid? id);
        public ScheduleDTO Get(Guid? id);
        public void Update(ScheduleDTO scheduleDTO);
        public void Create(ScheduleDTO scheduleDTO);
        Task CreateAsync(ScheduleDTO scheduleDTO);

    }

    public class ScheduleService : IScheduleService
    {
        private readonly IRepository<Schedule> _scheduleRepository;
        private readonly IMapper _mapper;

        public ScheduleService(
            IRepository<Schedule> scheduleRepository,
            IMapper mapper)
        {
            _scheduleRepository = scheduleRepository;
            _mapper = mapper;
        }
        public List<ScheduleDTO> GetAll()
        {
            var schedules = _scheduleRepository.GetAll();
            var result = _mapper.Map<List<ScheduleDTO>>(schedules);
            return result;
        }

        public void Delete(Guid? id)
        {
            _scheduleRepository.Delete(id);
        }

        public ScheduleDTO Get(Guid? id)
        {
            var schedule = _scheduleRepository.Get(id);
            var result = _mapper.Map<ScheduleDTO>(schedule);
            return result;
        }

        public void Update(ScheduleDTO scheduleDTO)
        {
            var schedule = _mapper.Map<Schedule>(scheduleDTO);
            _scheduleRepository.Update(schedule);
        }

        public void Create(ScheduleDTO scheduleDTO)
        {
            var schedule = _mapper.Map<Schedule>(scheduleDTO);
            _scheduleRepository.Create(schedule);
        }

        public async Task CreateAsync(ScheduleDTO scheduleDTO)
        {
            var schedule = _mapper.Map<Schedule>(scheduleDTO);
            await _scheduleRepository.CreateAsync(schedule);
        }
    }
}
