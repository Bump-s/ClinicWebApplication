using ClinicApp.DAL.Entities;
using ClinicApp.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClinicApp.DAL.Context.Repository
{
    public class ScheduleRepository : IRepository<Schedule>
    {
        private readonly EfContext _db;

        public ScheduleRepository(EfContext efContext)
        {
            _db = efContext;
        }

        public void Create(Schedule schedule)
        {
            _db.Schedules.Add(schedule);
            SaveChanges();
        }

        public async Task CreateAsync(Schedule schedule)
        {
           await _db.Schedules.AddAsync(schedule);
            SaveChanges();
        }

        public void Delete(Guid? id)
        {
            var schedule = _db.Schedules.Find(id);
            if (schedule != null)
                _db.Schedules.Remove(schedule);
            SaveChanges();
        }

        public Schedule Get(Guid? id)
        {
           return _db.Schedules.Find(id);
        }

        public IEnumerable<Schedule> GetAll()
        {
            return _db.Schedules;
        }

        public void Update(Schedule schedule)
        {
            _db.Entry(schedule).State = EntityState.Modified;
            SaveChanges();
        }
        private void SaveChanges()
        {
            _db.SaveChanges();
        }

    }
}
