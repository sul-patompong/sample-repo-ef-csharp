using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sample_repo_ef_csharp.Core;
using sample_repo_ef_csharp.Core.Domain;
using sample_repo_ef_csharp.Core.Repositories;
using sample_repo_ef_csharp.Persistence;
using sample_repo_ef_csharp.Persistence.Repositories;

namespace sample_repo_ef_csharp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet]
        [Route("/1")]
        public User GetLastUpdatedUser()
        {
            return _unitOfWork.Users.GetLastUpdatedUser();
        }

        [HttpGet]
        [Route("/2")]
        public List<User> GetAllUsers()
        {
            return _unitOfWork.Users.GetAll().ToList();
        }

        [HttpGet]
        [Route("/3")]
        public List<Car> GetAllCars()
        {
            return _unitOfWork.Cars.GetAll().ToList();
        }
    }
}
