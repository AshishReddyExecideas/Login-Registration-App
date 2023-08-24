using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<CityDto>> GetCities()
        {
            //var temp = new JsonResult(CitiesDataStore.Current.Cities);
            //temp.StatusCode = 200;
            return Ok(CitiesDataStore.Current.Cities);
            //return new JsonResult(
            //    new List<object>
            //    {
            //        new{id=1,Name="New York City"},
            //        new{id=2,Name="Antwerp"}
            //    }); 

        }

        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id) 
        {
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);

            if(cityToReturn == null)
            {
                return NotFound();
            }

            return Ok(cityToReturn); 
        }
    }
}
