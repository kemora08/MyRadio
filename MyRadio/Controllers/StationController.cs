using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyRadio.ApiModels;
using MyRadio.Core.Models;
using MyRadio.Core.Services;

namespace MyRadio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationController : ControllerBase
    {
        private readonly IStationService _stationService;

        public StationController(IStationService stationService)
        {
            _stationService = stationService;
        }
        // GET api/stations
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_stationService.GetAll().ToApiModels());
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("GetStation", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // GET api/stations/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var station = _stationService.Get(id);
                if (station is null)
                {
                    return null;
                }
                return Ok(station.ToApiModel());
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("GetStations", ex.Message);
                return BadRequest(ModelState);
            }
        }


        // POST api/stations
        [HttpPost]
        public IActionResult Post([FromBody] Station station)
        {
            try
            {
                return Ok(_stationService.Add(station).ToApiModel());
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("AddStation", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // PUT api/stations/{id}
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Station station)
        {
            try
            {
                return Ok(_stationService.Update(station).ToApiModel());
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("UpdateStation", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // DELETE api/stations/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _stationService.Remove(id);
                return Ok();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("DeleteStation", ex.Message);
                return BadRequest(ModelState);
            }
        }
    }
}
