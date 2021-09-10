using ClinicApp.DAL.Entities;
using ClinicApp.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClinicApp.DAL.Context.Repository
{
    public class SicknessRepository : IRepository<Sickness>
    {
        private readonly EfContext _db;
        public SicknessRepository(EfContext efContext)
        {
            _db = efContext;
        }
        public void Create(Sickness sickness)
        {
            _db.Sicknesses.Add(sickness);
            SaveChanges();
        }

        public Task CreateAsync(Sickness item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid? id)
        {
            var sickness = _db.Sicknesses.Find(id);
            if (sickness != null)
                _db.Sicknesses.Remove(sickness);
            SaveChanges();
        }

        public Sickness Get(Guid? id)
        {
            return _db.Sicknesses.Find(id);
        }

        public IEnumerable<Sickness> GetAll()
        {
            return _db.Sicknesses;
        }

        public void Update(Sickness sickness)
        {
            _db.Entry(sickness).State = EntityState.Modified;
            SaveChanges();
        }
        private void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
