using AutoMapper;
using ClinicApp.BLL.DTO;
using ClinicApp.DAL.Context.Repository;
using ClinicApp.DAL.Entities;
using ClinicApp.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace ClinicApp.BLL.Services
{
    public interface IAppointmentService
    {
        public List<AppointmentDTO> GetAll();
        public void Delete(Guid? id);
        public AppointmentDTO Get(Guid? id);
        public void Update(AppointmentDTO appointmentDTO);
        public void Create(AppointmentDTO appointmentDTO);
    }
    public class AppointmentService : IAppointmentService
    {
        private readonly IRepository<Appointment> _appointmentRepository;
        private readonly IMapper _mapper;

        public AppointmentService(
            IRepository<Appointment> appointmentRepository,
            IMapper mapper)
        {
           _appointmentRepository = appointmentRepository;
            _mapper = mapper;
        }
        public List<AppointmentDTO> GetAll()
        {
            var appointments = _appointmentRepository.GetAll();
            var result = _mapper.Map<List<AppointmentDTO>>(appointments);
            return result;
        }

        public void Delete(Guid? id)
        {
            _appointmentRepository.Delete(id);
        }

        public AppointmentDTO Get(Guid? id)
        {
            var appointment = _appointmentRepository.Get(id);
            var result = _mapper.Map<AppointmentDTO>(appointment);
            return result;
        }

        public void Update(AppointmentDTO appointmentDTO)
        {
            var appointment = _mapper.Map<Appointment>(appointmentDTO);
            _appointmentRepository.Update(appointment);
        }

        public void Create(AppointmentDTO appointmentDTO)
        {
            var appointment = _mapper.Map<Appointment>(appointmentDTO);
            appointment.Id = Guid.NewGuid();
            _appointmentRepository.Create(appointment);
        }  
    }
}
