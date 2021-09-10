using AutoMapper;
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
        private readonly IDoctorService _doctorService;
        private readonly IMapper _mapper;
        public DoctorController(
            IDoctorService doctorService,
            IMapper mapper)
        {
            _doctorService = doctorService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {

            var doctors = _doctorService.GetAll();
            var doctorsVM = _mapper.Map<List<DoctorViewModel>>(doctors);
            return View(doctorsVM);
        }
    }
}
