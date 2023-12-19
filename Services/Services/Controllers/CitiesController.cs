using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.Models;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AddCors")]
    public class CitiesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CitiesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Cities
        [HttpGet]
        public IEnumerable<CityModel> Getcities()
        {
            var list = from c in _context.cities orderby c.update_at descending select new CityModel { cityId = c.cityId,cityName = c.cityName,create_at=c.create_at,update_at=c.update_at };
            return list;
        }

        // GET: api/Cities/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCity([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var city = await _context.cities.FindAsync(id);

            if (city == null)
            {
                return NotFound();
            }

            return Ok(city);
        }

        // PUT: api/Cities/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCity([FromRoute] int id, [FromBody] City city)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != city.cityId)
            {
                return BadRequest();
            }

            _context.Entry(city).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Cities
        [HttpPost]
        public async Task<IActionResult> PostCity([FromBody] City city)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.cities.Add(city);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCity", new { id = city.cityId }, city);
        }

        // DELETE: api/Cities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCity([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var city = await _context.cities.FindAsync(id);
            if (city == null)
            {
                return NotFound();
            }

            _context.cities.Remove(city);
            await _context.SaveChangesAsync();

            return Ok(city);
        }

        private bool CityExists(int id)
        {
            return _context.cities.Any(e => e.cityId == id);
        }

        // --- //
        [HttpGet]
        [Route("searchC/{key}")]
        public async Task<IActionResult> SearchCityByNameContains(string key)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var listCities = from c in _context.cities where c.cityName.Contains(key) select new CityModel { cityId = c.cityId, cityName = c.cityName, create_at = c.create_at, update_at = c.update_at };


            if (listCities == null)
            {
                return NotFound();
            }

            return Ok(await listCities.ToListAsync());

        }
        [HttpGet]
        [Route("search/{key}")]
        public async Task<IActionResult> SearchCityByName(string key)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var listCities = from c in _context.cities where c.cityName.Equals(key) select new CityModel { cityId = c.cityId, cityName = c.cityName, create_at = c.create_at, update_at = c.update_at };


            if (listCities == null)
            {
                return NotFound();
            }

            return Ok(await listCities.ToListAsync());

        }
        [HttpGet]
        [Route("searchEdit/{key}&{id}")]
        public async Task<IActionResult> SearchCityByNameEdit(string key, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var listCities = from c in _context.cities where c.cityName.Equals(key) & c.cityId != id select new CityModel { cityId = c.cityId, cityName = c.cityName, create_at = c.create_at, update_at = c.update_at };


            if (listCities == null)
            {
                return NotFound();
            }

            return Ok(await listCities.ToListAsync());

        }
        [HttpGet]
        [Route("searchDistrictByCityId/{cityId}")]
        public async Task<IActionResult> SearchDisttristByCityId(int cityId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var listdistricts = from d in _context.districts where d.city.cityId == cityId select new DistrictModel { districtId = d.districtId, districtName = d.districtName, cityId = d.city.cityId, cityName = d.city.cityName };


            if (listdistricts == null)
            {
                return NotFound();
            }

            return Ok(await listdistricts.ToListAsync());

        }

      

    }
}