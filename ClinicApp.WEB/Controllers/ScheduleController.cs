using AutoMapper;
using ClinicApp.BLL.DTO;
using ClinicApp.BLL.Services;
using ClinicApp.WEB.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicApp.WEB.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class ScheduleController : Controller
    {
        private readonly IScheduleService _scheduleService;
        private readonly IMapper _mapper;
        private readonly IDoctorService _doctorService;
        public ScheduleController(
            IScheduleService scheduleService
            , IMapper mapper,
            IDoctorService doctorService)
        {
            _scheduleService = scheduleService;
            _mapper = mapper;
            _doctorService = doctorService;
        }
        [HttpGet]
        public IActionResult Create()
        {
            var doctors = _doctorService.GetAll().Select(s => s.Email);
            var schedule = new ScheduleViewModel();
            schedule.Emails = doctors.ToList();
            return View(schedule);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ScheduleViewModel model)
        {
            if (ModelState.IsValid)
            {
                var schedule = _mapper.Map<ScheduleDTO>(model);
                schedule.Id = Guid.NewGuid();

                var doctor =  _doctorService.GetByEmail(model.SelectedEmail);
                schedule.DoctorId = doctor.Id; 
                await _scheduleService.CreateAsync(schedule);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
