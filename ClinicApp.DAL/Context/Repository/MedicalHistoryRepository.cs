using ClinicApp.DAL.Entities;
using ClinicApp.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClinicApp.DAL.Context.Repository
{
    public class MedicalHistoryRepository : IRepository<MedicalHistory>
    {
        private readonly EfContext _db;

        public MedicalHistoryRepository(EfContext efContext)
        {
            _db = efContext;
        }
        public void Create(MedicalHistory medicalHistory)
        {
            _db.MedicalHistories.Add(medicalHistory);
            SaveChanges();
        }

        public Task CreateAsync(MedicalHistory item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid? id)
        {
            var medicalHistory = _db.MedicalHistories.Find(id);
            if (medicalHistory != null)
                _db.MedicalHistories.Remove(medicalHistory);
            SaveChanges();
        }

        public MedicalHistory Get(Guid? id)
        {
            return _db.MedicalHistories.Find(id);
        }

        public IEnumerable<MedicalHistory> GetAll()
        {
            return _db.MedicalHistories;
        }

        public void Update(MedicalHistory medicalHistory)
        {
            _db.Entry(medicalHistory).State = EntityState.Modified;
            SaveChanges();
        }
        private void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
