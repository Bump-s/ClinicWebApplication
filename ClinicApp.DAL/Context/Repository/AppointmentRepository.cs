using ClinicApp.DAL.Entities;
using ClinicApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ClinicApp.DAL.Context.Repository
{
    public class AppointmentRepository : IRepository<Appointment>
    {
        private readonly EfContext _db;
        public AppointmentRepository(EfContext efContext)
        {
            _db = efContext;
        }
        public void Create(Appointment appointment)
        {
            _db.Appointments.Add(appointment);
            SaveChanges();
        }

        public Task CreateAsync(Appointment item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid? id)
        {
            var appointment = _db.Appointments.Find(id);
            if (appointment != null)
                _db.Appointments.Remove(appointment);
            SaveChanges();
        }

        public Appointment Get(Guid? id)
        {
           return _db.Appointments.Find(id);
        }

        public IEnumerable<Appointment> GetAll()
        {
            return _db.Appointments;
        }

        public void Update(Appointment appointment)
        {
            _db.Entry(appointment).State = EntityState.Modified;
            SaveChanges();
        }
        private void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
