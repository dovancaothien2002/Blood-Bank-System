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
    public class BloodsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BloodsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Bloods
        [HttpGet]
        public IEnumerable<BloodModel> Getbloods()
        {
            var list = from b in _context.bloods orderby b.update_at descending select new BloodModel { bloodId = b.bloodId, bloodName = b.bloodName,create_at = b.create_at ,update_at = b.update_at};
            return list;
        }

        // GET: api/Bloods/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlood([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var blood = await _context.bloods.FindAsync(id);

            if (blood == null)
            {
                return NotFound();
            }

            return Ok(blood);
        }

        // PUT: api/Bloods/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBlood([FromRoute] int id, [FromBody] Blood blood)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != blood.bloodId)
            {
                return BadRequest();
            }

            _context.Entry(blood).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BloodExists(id))
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

        // POST: api/Bloods
        [HttpPost]
        public async Task<IActionResult> PostBlood([FromBody] Blood blood)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = _context.bloods.Add(blood);

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBlood", new { id = blood.bloodId }, blood);
        }

        // DELETE: api/Bloods/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlood([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var blood = await _context.bloods.FindAsync(id);
            if (blood == null)
            {
                return NotFound();
            }

            _context.bloods.Remove(blood);
            await _context.SaveChangesAsync();

            return Ok(blood);
        }

        private bool BloodExists(int id)
        {
            return _context.bloods.Any(e => e.bloodId == id);
        }

        // -----------------//

        [HttpGet]
        [Route("search/{key}")]
        public async Task<IActionResult> SearchBloodByName(string key)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var listB = from b in _context.bloods where b.bloodName.Equals(key) select new BloodModel { bloodId = b.bloodId, bloodName = b.bloodName, create_at = b.create_at, update_at = b.update_at };


            if (listB == null)
            {
                return NotFound();
            }

            return Ok(await listB.ToListAsync());

        }

        [HttpGet]
        [Route("searchEdit/{key}&{id}")]
        public async Task<IActionResult> SearchBloodByNameEdit(string key, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var listB = from b in _context.bloods where b.bloodName.Equals(key) & b.bloodId != id select new BloodModel { bloodId = b.bloodId, bloodName = b.bloodName, create_at = b.create_at, update_at = b.update_at };


            if (listB == null)
            {
                return NotFound();
            }

            return Ok(await listB.ToListAsync());

        }

    }
}