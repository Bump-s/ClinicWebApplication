using AutoMapper;
using ClinicApp.BLL.DTO;
using ClinicApp.BLL.Services;
using ClinicApp.WEB.Areas.Doctor.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicApp.WEB.Areas.Doctor.Controllers
{
    [Area("Doctor")]
    [Authorize(Roles = "Admin")]
    public class DoctorRegisterController : Controller
    {
        private readonly IDoctorService _doctorService;
        private readonly IMapper _mapper;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public DoctorRegisterController(
            IDoctorService doctorService,
            IMapper mapper,
            SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager)
        {
            _doctorService = doctorService;
            _mapper = mapper;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(DoctorRegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var doctor = _mapper.Map<DoctorDTO>(model);
                var userId = Guid.NewGuid();
                doctor.Id = userId;
                IdentityUser user = new IdentityUser { Id = userId.ToString(), UserName = model.Email, Email = model.Email, PhoneNumber = model.PhoneNumber };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Doctor");

                    await _signInManager.SignInAsync(user, false);
                    _doctorService.Create(doctor);
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
