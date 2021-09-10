using AutoMapper;
using ClinicApp.BLL.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicApp.WEB.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientService _patientService;
        private readonly IMapper _mapper;
        PatientController(
            IPatientService patientService,
            IMapper mapper)
        {
            _patientService = patientService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
