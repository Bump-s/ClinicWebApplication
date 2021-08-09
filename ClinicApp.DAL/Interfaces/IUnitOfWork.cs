using ClinicApp.DAL.Entities;
using System;


namespace ClinicApp.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository <Doktor> Dorkors { get; }
        void Save();
    }
}
