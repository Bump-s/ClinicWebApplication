using AutoMapper;
using ClinicApp.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClinicApp.WEB.Controllers
{
    public class SicknessController : Controller
    {
        private readonly ISicknessService _sicnessService;
        private readonly IMapper _mapper;
        public SicknessController(
            ISicknessService sicnessService,
            IMapper mapper)
        {
            _sicnessService = sicnessService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
