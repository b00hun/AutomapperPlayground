using AutoMapper;
using Ex7_Bartosz_Sadowski.Dto;
using Ex7_Bartosz_Sadowski.Models;
using Ex7_Bartosz_Sadowski.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ex7_Bartosz_Sadowski.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;
        private readonly ICarRepository _repository;

        public HomeController(ILogger<HomeController> logger,IMapper mapper, ICarRepository repository)
        {
            _logger = logger;
            _mapper = mapper;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            var cars = _repository.GetAllCars();
            var carMaps = _mapper.Map<IList<CarDto>>(cars);
            return View(carMaps);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
