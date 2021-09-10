using AutoMapper;
using ClinicApp.BLL.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicApp.WEB.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IMapper _mapper;
        public AppointmentController(
            IAppointmentService appointmentService,
            IMapper mapper)
        {
            _appointmentService = appointmentService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }


    }
}
