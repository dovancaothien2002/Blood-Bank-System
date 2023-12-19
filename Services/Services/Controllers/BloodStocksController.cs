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

    public class BloodStocksController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BloodStocksController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/BloodStocks
        [HttpGet]
        public IEnumerable<BloodStock> GetbloodStocks()
        {
            return _context.bloodStocks;
        }

        // GET: api/BloodStocks/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBloodStock([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bloodStock = await _context.bloodStocks.Include(bs => bs.blood).Include(bs => bs.bloodBank).FirstOrDefaultAsync(bs => bs.bloodstockId == id);

            if (bloodStock == null)
            {
                return NotFound();
            }
            else
            {
                var bsModel = new BloodStockModel
                {
                    bloodstockId = bloodStock.bloodstockId,
                    bbId = bloodStock.bloodBank.bbId,
                    bbName = bloodStock.bloodBank.bbName,
                    bloodId = bloodStock.blood.bloodId,
                    bloodName = bloodStock.blood.bloodName,
                    create_at = bloodStock.create_at,
                    update_at = bloodStock.update_at,
                    quantity = bloodStock.quantity
                };

                return Ok(bsModel);
            }

           
        }

        [HttpGet]
        [Route("checkBloodStock/{bbId}&{bloodId}")]
        public async Task<IActionResult> CheckBloodStock(int bbId, int bloodId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bs = await _context.bloodStocks.Include(bss => bss.blood).Include(bss => bss.bloodBank).FirstOrDefaultAsync(bss => bss.bbId == bbId && bss.bloodId == bloodId);
            if (bs == null)
            {
                return NoContent();
            }
            else
            {
                BloodStockModel bsModel = new BloodStockModel
                {
                    bloodstockId = bs.bloodstockId,
                    quantity = bs.quantity,
                    create_at = bs.create_at,
                    update_at = bs.update_at,

                    bbId = bs.bloodBank.bbId,
                    bbName = bs.bloodBank.bbName,

                    bloodId = bs.blood.bloodId,
                    bloodName = bs.blood.bloodName

                };
                return Ok(bsModel);
            }

        }

        [HttpGet]
        [Route("searchlistblood/{bbId}")]
        public async Task<IActionResult> SearchListBlood(int bbId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var listId = from bs in _context.bloodStocks where bs.bbId == bbId select bs.bloodId;
            var bModel = from b in _context.bloods where !listId.Contains(b.bloodId)
                          select new BloodModel
                          {
                             bloodId = b.bloodId,
                             bloodName = b.bloodName,
                             create_at = b.create_at,
                             update_at = b.update_at
                          };

            if (bModel == null)
            {
                return NotFound();
            }

            return Ok(await bModel.ToListAsync());

        }

        [HttpGet]
        [Route("searchbs/{bbId}")]
        public async Task<IActionResult> SearchBloodStock(int bbId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bsModel = from bs in _context.bloodStocks
                          join bb in _context.bloodBanks on bs.bbId equals bb.bbId
                          join b in _context.bloods on bs.bloodId equals b.bloodId

                          where bs.bbId == bbId
                          select new BloodStockModelB
                          {
                              bloodstockId = bs.bloodstockId,
                              quantity = bs.quantity,
                              create_at = bb.create_at,
                              update_at = bb.update_at,

                              bbId = bb.bbId,
                              bbName = bb.bbName,
                              bbAddress = bb.address,
                              bbCalendar = bb.calendar,
                              bbEmail = bb.email,
                              bbHotline = bb.hotline,

                              bloodId = b.bloodId,
                              bloodName = b.bloodName

                          };

            if (bsModel == null)
            {
                return NotFound();
            }

            return Ok(await bsModel.ToListAsync());

        }

        // PUT: api/BloodStocks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBloodStock([FromRoute] int id, [FromBody] BloodStock bloodStock)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bloodStock.bloodstockId)
            {
                return BadRequest();
            }

            _context.Entry(bloodStock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BloodStockExists(id))
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

        // POST: api/BloodStocks
        [HttpPost]
        public async Task<IActionResult> PostBloodStock([FromBody] BloodStock bloodStock)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.bloodStocks.Add(bloodStock);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBloodStock", new { id = bloodStock.bloodstockId }, bloodStock);
        }

        // DELETE: api/BloodStocks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBloodStock([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bloodStock = await _context.bloodStocks.FindAsync(id);
            if (bloodStock == null)
            {
                return NotFound();
            }

            _context.bloodStocks.Remove(bloodStock);
            await _context.SaveChangesAsync();

            return Ok(bloodStock);
        }

        private bool BloodStockExists(int id)
        {
            return _context.bloodStocks.Any(e => e.bloodstockId == id);
        }
    }
}