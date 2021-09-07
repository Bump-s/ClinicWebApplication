using ClinicApp.BLL.Services;
using ClinicApp.DAL.Context.Repository;
using ClinicApp.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicApp.WEB.Controllers
{
    public class DoctorController : Controller
    {
        private readonly DoctorService _doctorService;

        public DoctorController()
        {
            _doctorService = new DoctorService();
        }
        public IActionResult Index()
        {

            var doctors = _doctorService.GetAll();
            var doctorsVM = doctors.Select(doctor => new DoctorViewModel
            {
                FullName = doctor.FullName,
                Email = doctor.Email,
                PhoneNumber = doctor.PhoneNumber,
                Id = doctor.Id
            });
            return View(doctorsVM.ToList());
        }
    }
}
