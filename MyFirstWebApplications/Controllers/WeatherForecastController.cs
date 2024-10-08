﻿using Microsoft.AspNetCore.Mvc;
using MyFirstWebApplications.Models;

namespace MyFirstWebApplications.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {

        private WeatherForecastHolder _weatherForecastHolder;

        public WeatherForecastController(
            WeatherForecastHolder weatherForecastHolder)
        {
            _weatherForecastHolder = weatherForecastHolder;
        }

        [HttpPost("add")]
        public IActionResult Add([FromQuery] DateTime date, [FromQuery] int temperatureC) 
        {
            _weatherForecastHolder.Add(date, temperatureC);
            return Ok();
        }

        [HttpGet("get")]
        public IActionResult Get([FromQuery] DateTime dateFrom, [FromQuery] DateTime dateTo)
        {
            List<WeatherForecast> list = _weatherForecastHolder.Get(dateFrom, dateTo);
            return Ok(list);
        }

        [HttpPut("update")]
        public IActionResult Update([FromQuery] DateTime date, [FromQuery] int temperatureC)
        {
            _weatherForecastHolder.Update(date, temperatureC);
            return Ok();
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] DateTime date)
        {
            _weatherForecastHolder.Delete(date);
            return Ok();
        }

    }
}
