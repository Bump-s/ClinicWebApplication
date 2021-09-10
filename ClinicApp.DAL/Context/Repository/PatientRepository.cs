using ClinicApp.DAL.Entities;
using ClinicApp.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClinicApp.DAL.Context.Repository
{
    public class PatientRepository : IRepository<Patient>
    {
        private readonly EfContext _db;

        public PatientRepository(EfContext efContext)
        {
            _db = efContext;
        }

        public void Create(Patient patient)
        {
            _db.Patients.Add(patient);
            SaveChanges();
        }

        public Task CreateAsync(Patient item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid? id)
        {
            var patient = _db.Patients.Find(id);
            if (patient != null)
                _db.Patients.Remove(patient);
            SaveChanges();
        }

        public Patient Get(Guid? id)
        {
            return _db.Patients.Find(id);
        }

        public IEnumerable<Patient> GetAll()
        {
            return _db.Patients;
        }

        public void Update(Patient patient)
        {
            _db.Entry(patient).State = EntityState.Modified;
            SaveChanges();
        }
        private void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
