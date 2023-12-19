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
    public class DistrictsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DistrictsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Districts
        [HttpGet]
        public IEnumerable<DistrictModel> Getdistricts()
        {
            var list = from d in _context.districts orderby d.update_at descending select new DistrictModel { districtId = d.districtId, districtName = d.districtName, cityId = d.city.cityId, cityName = d.city.cityName ,create_at = d.create_at,update_at = d.update_at};
            return list;
        }


        [HttpGet]
        [Route("search/{id}")]
        public async Task<IActionResult> SearchDistrictByCitytId(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var listdistricts = from d in _context.districts where d.city.cityId == id select new DistrictModel { districtId = d.districtId, districtName = d.districtName, cityId = d.city.cityId, cityName = d.city.cityName };


            if (listdistricts == null)
            {
                return NotFound();
            }

            return Ok(await listdistricts.ToListAsync());

        }

        // GET: api/Districts/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDistrict([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var d = await _context.districts.Include(dd=> dd.city).FirstOrDefaultAsync(dd => dd.districtId == id);

            if (d == null)
            {
                return NotFound();
            }
            else
            {
               DistrictModel district =  new DistrictModel { districtId = d.districtId, districtName = d.districtName, cityId = d.city.cityId, cityName = d.city.cityName };
            }

            return Ok(d);
        }

        // PUT: api/Districts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDistrict([FromRoute] int id, [FromBody] District district)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != district.districtId)
            {
                return BadRequest();
            }

            _context.Entry(district).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DistrictExists(id))
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

        // POST: api/Districts
        [HttpPost]
        public async Task<IActionResult> PostDistrict([FromBody] District district)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.districts.Add(district);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDistrict", new { id = district.districtId }, district);
        }

        // DELETE: api/Districts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDistrict([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var district = await _context.districts.FindAsync(id);
            if (district == null)
            {
                return NotFound();
            }

            _context.districts.Remove(district);
            await _context.SaveChangesAsync();

            return Ok(district);
        }

        private bool DistrictExists(int id)
        {
            return _context.districts.Any(e => e.districtId == id);
        }

        // ========== //

        [HttpGet]
        [Route("searchBloodBank/{id}")]
        public async Task<IActionResult> SearchBloodBankByDistricttId(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var listBb = from d in _context.bloodBanks where d.district.districtId == id select d;


            if (listBb == null)
            {
                return NotFound();
            }

            return Ok(await listBb.ToListAsync());

        }

        [HttpGet]
        [Route("searchByName/{key}")]
        public async Task<IActionResult> SearchByName(string key)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var listDistricts = from d in _context.districts where d.districtName.Equals(key) select new DistrictModel { districtId = d.districtId, districtName = d.districtName, cityId = d.city.cityId, cityName = d.city.cityName };


            if (listDistricts == null)
            {
                return NotFound();
            }

            return Ok(await listDistricts.ToListAsync());

        }
        [HttpGet]
        [Route("searchC/{key}")]
        public async Task<IActionResult> SearchDistrictsByNameContains(string key)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var listDistricts = from d in _context.districts where d.districtName.Contains(key) select new DistrictModel { districtId = d.districtId, districtName = d.districtName, cityId = d.city.cityId, cityName = d.city.cityName };


            if (listDistricts == null)
            {
                return NotFound();
            }

            return Ok(await listDistricts.ToListAsync());

        }
        [HttpGet]
        [Route("searchEdit/{key}&{id}")]
        public async Task<IActionResult> SearchDistrictsByNameEdit(string key, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var listDistricts = from d in _context.districts where d.districtName.Equals(key) & d.districtId != id select new DistrictModel { districtId = d.districtId, districtName = d.districtName, cityId = d.city.cityId, cityName = d.city.cityName };


            if (listDistricts == null)
            {
                return NotFound();
            }

            return Ok(await listDistricts.ToListAsync());

        }
    }
}