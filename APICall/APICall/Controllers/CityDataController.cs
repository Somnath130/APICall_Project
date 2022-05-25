using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APICall.Models;
using APICall.RequestModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICall.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityDataController : ControllerBase
    {
        private readonly CityDataContext _citydatacontext;

        public CityDataController(CityDataContext cityValue)  
        {
            _citydatacontext = cityValue;
        }
        // GET: api/CityData
        [HttpGet]
       public IActionResult Get()
        {
            var cityData = _citydatacontext.City.ToList();
            return Ok(cityData);
        }


        [HttpGet("{id:int}")]

        public IActionResult Gettwo(int id)
        {
            try
            {
                var res = _citydatacontext.City.First(o => o.CityId == id);



                if (res == null)
                    return NotFound();
                return Ok(res);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status204NoContent, "Not Found");
            }
        }


        // GET: api/CityData/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CityData
        [HttpPost]
        public void Post([FromBody] CityDataRequest value)
                
        {
            City cityData = new City();
            cityData.City1 = value.City1;
            cityData.State = value.State;
            cityData.Location = value.Location;
            cityData.Pincode = value.Pincode;
            cityData.AreaSqKm = value.AreaSqKm;
            cityData.CricketStadium = value.CricketStadium;
        }

        // PUT: api/CityData/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
