using ClinicApp.DAL.Entities;
using ClinicApp.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.DAL.Context.Repository
{
    public class DoctorRepository : IRepository<Doctor>
    {
        private readonly EfContext _db;

        public DoctorRepository()
        {
            _db = new EfContext();
        }
        public void Create(Doctor doctor)
        {
            _db.Doctors.Add(doctor);
        }

        public void Delete(Guid? id)
        {
            var doctor = _db.Doctors.Find(id);
            if (doctor != null)
                _db.Doctors.Remove(doctor);
        }

        public Doctor Get(Guid? id)
        {
            return _db.Doctors.Find(id);
        }

        public IEnumerable<Doctor> GetAll()
        {
            return _db.Doctors;
        }

        public void Update(Doctor doctor)
        {
            _db.Entry(doctor).State = EntityState.Modified;
        }
    }
}
