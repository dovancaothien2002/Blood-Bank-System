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
    public class BloodBanksController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BloodBanksController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/BloodBanks
        [HttpGet]
        public IEnumerable<BloodBankModel> GetbloodBanks()
        {
            var list = from bb in _context.bloodBanks orderby bb.update_at descending
                       select new BloodBankModel
                       {
                           bbId = bb.bbId,
                           bbName = bb.bbName,
                           address = bb.address,
                           districtId = bb.district.districtId,
                           districtName = bb.district.districtName,
                           calendar = bb.calendar,
                           create_at = bb.create_at,
                           email = bb.email,
                           password = bb.password,
                           hotline = bb.hotline,
                           update_at = bb.update_at,
                          
                       };
            return list;
        }

        [HttpGet]
        [Route("searchbs/{districtId}&{bloodId}")]
        public async Task<IActionResult> SearchBloodStock(int districtId, int bloodId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
        
            var bsModel = from bs in _context.bloodStocks
                          join bb in _context.bloodBanks on bs.bbId equals bb.bbId
                          join b in _context.bloods on bs.bloodId equals b.bloodId

                          where bb.district.districtId == districtId & b.bloodId == bloodId
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


        [HttpGet]
        [Route("searchbb/{districtId}")]
        public async Task<IActionResult> SearchBloodBank(int districtId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bbModel = from bb in _context.bloodBanks
                         
                          join d in _context.districts on bb.districtId equals d.districtId

                          where bb.district.districtId == districtId
                          select new BloodBankModel
                          {
                              bbId = bb.bbId,
                              bbName = bb.bbName,
                              address = bb.address,
                              calendar = bb.calendar,
                              email = bb.email,
                              password = bb.password,
                              hotline = bb.hotline

                          };

            if (bbModel == null)
            {
                return NotFound();
            }

            return Ok(await bbModel.ToListAsync());

        }

      

        // PUT: api/BloodBanks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBloodBank([FromRoute] int id, [FromBody] BloodBank bloodBank)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bloodBank.bbId)
            {
                return BadRequest();
            }

            _context.Entry(bloodBank).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BloodBankExists(id))
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

        // POST: api/BloodBanks
        [HttpPost]
        public async Task<IActionResult> PostBloodBank([FromBody] BloodBank bloodBank)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.bloodBanks.Add(bloodBank);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBloodBank", new { id = bloodBank.bbId }, bloodBank);
        }

        // DELETE: api/BloodBanks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBloodBank([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bloodBank = await _context.bloodBanks.FindAsync(id);
            if (bloodBank == null)
            {
                return NotFound();
            }

            _context.bloodBanks.Remove(bloodBank);
            await _context.SaveChangesAsync();

            return Ok(bloodBank);
        }

        private bool BloodBankExists(int id)
        {
            return _context.bloodBanks.Any(e => e.bbId == id);
        }


        // ---------------- //

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginBloodbank model)
        {
            var bloodBank = _context.bloodBanks.Include(b => b.district).FirstOrDefault(x => x.email == model.Email &&
               x.password == model.Password);

            //nếu tồn tại thì xử lý sing token
            if (bloodBank != null)
            {
                var bbModel = new BloodBankModel
                {
                    bbId = bloodBank.bbId,
                    bbName = bloodBank.bbName,
                    address = bloodBank.address,
                    districtId = bloodBank.district.districtId,
                    districtName = bloodBank.district.districtName,
                    calendar = bloodBank.calendar,
                    create_at = bloodBank.create_at,
                    email = bloodBank.email,
                    password = bloodBank.password,
                    hotline = bloodBank.hotline,
                    update_at = bloodBank.update_at
                };



                return Ok(bbModel);
            }
            //trả về lỗi
            return NotFound();
        }


        [HttpGet]
        [Route("searchByName/{key}")]
        public async Task<IActionResult> SearchByName(string key)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var listBloodBanks = from bb in _context.bloodBanks
                                 where bb.bbName.Equals(key)
                                 select new BloodBankModel
                                 {
                                     bbId = bb.bbId,
                                     bbName = bb.bbName,
                                     address = bb.address,
                                     districtId = bb.district.districtId,
                                     districtName = bb.district.districtName,
                                     calendar = bb.calendar,
                                     create_at = bb.create_at,
                                     email = bb.email,
                                     password = bb.password,
                                     hotline = bb.hotline,
                                     update_at = bb.update_at
                                 };


            if (listBloodBanks == null)
            {
                return NotFound();
            }

            return Ok(await listBloodBanks.ToListAsync());

        }
        [HttpGet]
        [Route("searchByNameEdit/{key}&{id}")]
        public async Task<IActionResult> SearchByNameEdit(string key, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var listBloodBanks = from bb in _context.bloodBanks
                                 where bb.bbName.Equals(key) & bb.bbId != id
                                 select new BloodBankModel
                                 {
                                     bbId = bb.bbId,
                                     bbName = bb.bbName,
                                     address = bb.address,
                                     districtId = bb.district.districtId,
                                     districtName = bb.district.districtName,
                                     calendar = bb.calendar,
                                     create_at = bb.create_at,
                                     email = bb.email,
                                     password = bb.password,
                                     hotline = bb.hotline,
                                     update_at = bb.update_at
                                 };


            if (listBloodBanks == null)
            {
                return NotFound();
            }

            return Ok(await listBloodBanks.ToListAsync());

        }

        // GET: api/BloodBanks/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBloodBank([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bloodBank = await _context.bloodBanks.Include(bb => bb.district).FirstOrDefaultAsync(b => b.bbId.Equals(id));



            if (bloodBank == null)
            {
                return NotFound();
            }
            else
            {
                var bbModel = new BloodBankModel
                {
                    bbId = bloodBank.bbId,
                    bbName = bloodBank.bbName,
                    address = bloodBank.address,
                    districtId = bloodBank.district.districtId,
                    districtName = bloodBank.district.districtName,
                    calendar = bloodBank.calendar,
                    create_at = bloodBank.create_at,
                    email = bloodBank.email,
                    password = bloodBank.password,
                    hotline = bloodBank.hotline,
                    update_at = bloodBank.update_at
                };

                return Ok(bbModel);
            }
        }

        [HttpGet]
        [Route("searchByNameC/{key}")]
        public async Task<IActionResult> SearchByNameContains(string key)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var listBloodBanks = from bb in _context.bloodBanks
                                 where bb.bbName.Contains(key)
                                 select new BloodBankModel
                                 {
                                     bbId = bb.bbId,
                                     bbName = bb.bbName,
                                     address = bb.address,
                                     districtId = bb.district.districtId,
                                     districtName = bb.district.districtName,
                                     calendar = bb.calendar,
                                     create_at = bb.create_at,
                                     email = bb.email,
                                     password = bb.password,
                                     hotline = bb.hotline,
                                     update_at = bb.update_at
                                 };


            if (listBloodBanks == null)
            {
                return NotFound();
            }

            return Ok(await listBloodBanks.ToListAsync());

        }

    }
}