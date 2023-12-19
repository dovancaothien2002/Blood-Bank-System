using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AddCors")]
    public class DonorsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DonorsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Donors
        [HttpGet]
        public IEnumerable<DonorModel> Getdonors()
        {
            var list = from d in _context.donors
                       select new DonorModel
                       {
                           donorId = d.donorId, donorName = d.donorName,
                           address = d.address, age = d.age,
                           bloodName = d.blood.bloodName, bloodId = d.blood.bloodId,
                           districtId = d.district.districtId,districtName = d.district.districtName,
                           create_at = d.create_at, update_at = d.update_at,
                           email = d.email, phone = d.phone,
                           status = d.status, gender = d.gender,
                           weight = d.weight, password = d.password,
                           birthday = d.birthday
                       };
            return list;
        }

        // GET: api/Donors/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDonor([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var d = await _context.donors.Include(dd => dd.blood).Include(dd => dd.district).FirstOrDefaultAsync(dd => dd.donorId == id);

            if (d == null)
            {
                return NotFound();
            }
            else
            {
                var donor = new DonorModel
                {
                    donorId = d.donorId,
                    donorName = d.donorName,
                    address = d.address,
                    age = d.age,
                    bloodName = d.blood.bloodName,
                    bloodId = d.blood.bloodId,
                    districtId = d.district.districtId,
                    districtName = d.district.districtName,
                    create_at = d.create_at,
                    update_at = d.update_at,
                    email = d.email,
                    phone = d.phone,
                    status = d.status,
                    gender = d.gender,
                    weight = d.weight,
                    password = d.password,
                    birthday = d.birthday
                };
                return Ok(donor);
            }


        }

        [HttpGet]
        [Route("search/{districtId}&{bloodId}")]
        public async Task<IActionResult> SearchBloodBank(int districtId, int bloodId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var donor = from d in _context.donors where d.blood.bloodId == bloodId && d.district.districtId == districtId
                        select new DonorModel
                        {
                            donorId = d.donorId,
                            donorName = d.donorName,
                            address = d.address,
                            age = d.age,
                            bloodName = d.blood.bloodName,
                            bloodId = d.blood.bloodId,
                            districtId = d.district.districtId,
                            districtName = d.district.districtName,
                            create_at = d.create_at,
                            update_at = d.update_at,
                            email = d.email,
                            phone = d.phone,
                            status = d.status,
                            gender = d.gender,
                            weight = d.weight,
                            password = d.password,
                            birthday = d.birthday
                        };

            if (donor == null)
            {
                return NotFound();
            }

            return Ok(await donor.ToListAsync());

        }

        // PUT: api/Donors/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDonor([FromRoute] int id, [FromBody] Donor donor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != donor.donorId)
            {
                return BadRequest();
            }

            _context.Entry(donor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DonorExists(id))
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

        // POST: api/Donors
        [HttpPost]
        public async Task<IActionResult> PostDonor([FromBody] Donor donor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.donors.Add(donor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDonor", new { id = donor.donorId }, donor);
        }

        // DELETE: api/Donors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDonor([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var donor = await _context.donors.FindAsync(id);
            if (donor == null)
            {
                return NotFound();
            }

            _context.donors.Remove(donor);
            await _context.SaveChangesAsync();

            return Ok(donor);
        }

        private bool DonorExists(int id)
        {
            return _context.donors.Any(e => e.donorId == id);
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login([FromBody] Login donor)
        {
            var d = _context.donors.Include(dr => dr.blood).Include(dr => dr.district).FirstOrDefault(c => c.email == donor.email && c.password == donor.password);

            if (d != null)
            {
                var result = new DonorModel
                {
                    donorId = d.donorId,
                    donorName = d.donorName,
                    address = d.address,
                    age = d.age,
                    bloodName = d.blood.bloodName,
                    bloodId = d.blood.bloodId,
                    districtId = d.district.districtId,
                    districtName = d.district.districtName,
                    create_at = d.create_at,
                    update_at = d.update_at,
                    email = d.email,
                    phone = d.phone,
                    status = d.status,
                    gender = d.gender,
                    weight = d.weight,
                    password = d.password,
                    birthday = d.birthday
                };

                return Ok(result);
            }

            return NoContent();

        }

        [HttpPost]
        [Route("checkUniqueEmail")]
        public async Task<IActionResult> checkUniqueEmail([FromBody] dynamic data)
        {
            int donorId = data.donorId;
            string donorEmail = data.donorEmail;
            var d = new Donor();
            if (donorId == 0) {
                d = await _context.donors.Include(donor => donor.blood).Include(dr => dr.district).FirstOrDefaultAsync(donor => donor.email == donorEmail);
            }
            else
            {
                d = await _context.donors.Include(donor => donor.blood).Include(dr => dr.district).FirstOrDefaultAsync(donor => donor.email == donorEmail && donor.donorId != donorId);
            }

            if(d != null)
            {
                var result = new DonorModel
                {
                    donorId = d.donorId,
                    donorName = d.donorName,
                    address = d.address,
                    age = d.age,
                    bloodName = d.blood.bloodName,
                    bloodId = d.blood.bloodId,
                    districtId = d.district.districtId,
                    districtName = d.district.districtName,
                    create_at = d.create_at,
                    update_at = d.update_at,
                    email = d.email,
                    phone = d.phone,
                    status = d.status,
                    gender = d.gender,
                    weight = d.weight,
                    password = d.password,
                    birthday = d.birthday
                };

                return Ok(result);
            }
            else
            {
                return NoContent();
            }
           
        }
    }
}