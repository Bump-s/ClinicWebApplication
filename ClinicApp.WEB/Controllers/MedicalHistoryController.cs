using AutoMapper;
using ClinicApp.BLL.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicApp.WEB.Controllers
{
    public class MedicalHistoryController : Controller
    {
        private readonly IMedicalHistoryService _medicalHistoryService;
        private readonly IMapper _mapper;
        public MedicalHistoryController(
            IMedicalHistoryService medicalHistoryService, 
            IMapper mapper)
        {
            _medicalHistoryService = medicalHistoryService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
