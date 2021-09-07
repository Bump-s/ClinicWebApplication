using ClinicApp.BLL.DTO;
using ClinicApp.DAL.Entities;
using ClinicApp.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicApp.WEB.Controllers
{
    public class HomeController : Controller
    {
        //private List<DoctorViewModel> doctors = new List<DoctorViewModel> {
        //    new DoctorViewModel { FullName = "Aaaa", Email = "aaaa@aaa.com", Id = Guid.NewGuid(), PhoneNumber = "+3904821479"},
        //    new DoctorViewModel { FullName = "Bbbb", Email = "bbbb@bbb.com", Id = Guid.NewGuid(), PhoneNumber = "+3904123527"},
        //    new DoctorViewModel { FullName = "Cccc", Email = "cccc@ccc.com", Id = Guid.NewGuid(), PhoneNumber = "+3902125561"},
        //    new DoctorViewModel { FullName = "Dddd", Email = "dddd@ddd.com", Id = Guid.NewGuid(), PhoneNumber = "+3909562324"},
        //};

        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult CreateDoctor()
        //{
        //    return View(new DoctorViewModel() { Id = Guid.NewGuid() });
        //}

        //[HttpPost]
        //public IActionResult CreateDoctor(Doctor doctor)
        //{
        //    string userInfo = $"Name: {doctor.UserName}  Email: {doctor.Email} Phone: {doctor.PhoneNumber}";
        //    return Content(userInfo);
        //}
    }
}

