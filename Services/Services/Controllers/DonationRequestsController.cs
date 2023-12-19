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
    public class DonationRequestsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DonationRequestsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/DonationRequests
        [HttpGet]
        public IEnumerable<DonationRequest> GetdonorRequests()
        {
            return _context.donorRequests;
        }

        // GET: api/DonationRequests/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDonationRequest([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var rq = await _context.donorRequests.Include(rqs => rqs.donor).Include(rqs => rqs.bloodBank).Include(rqs => rqs.donor.blood).FirstOrDefaultAsync(rqs=>rqs.drId == id);

            if (rq == null)
            {
                return NotFound();
            }
            else
            {
                DonationRequestModelB dRqModel = new DonationRequestModelB
                {
                    drId = rq.drId,
                    bbId = rq.bloodBank.bbId,
                    bbName = rq.bloodBank.bbName,
                    amount = rq.amount,
                    note = rq.note,
                    status = rq.status,
                    expected_date = rq.expected_date,

                    donorId = rq.donor.donorId,
                    donorName = rq.donor.donorName,
                    donorEmail = rq.donor.email,
                    donorPhone = rq.donor.phone,
                    donorAddress = rq.donor.address,
                    donordAge = rq.donor.age,
                    donorGender = rq.donor.gender,
                    donorBirthday = rq.donor.birthday,
                    donorWeight = rq.donor.weight,
                    donorStatus = rq.donor.status,
                    donorBloodId = rq.donor.blood.bloodId,
                    donorBloodName = rq.donor.blood.bloodName,

                    create_at = rq.create_at,
                    update_at = rq.update_at
                };
                return Ok(dRqModel);
            }

           
        }

        [HttpGet]
        [Route("searchbydonor/{donorId}")]
        public async Task<IActionResult> searchbyDonor(int donorId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var rqModel = from rq in _context.donorRequests
                          where rq.donorId == donorId
                          select new DonationRequestModel
                          {
                              drId = rq.drId,
                              bbId = rq.bloodBank.bbId,
                              bbName = rq.bloodBank.bbName,

                              amount = rq.amount,
                              note = rq.note,

                              status = rq.status,

                              donorId = rq.donor.donorId,
                              donorName = rq.donor.donorName,

                              expected_date = rq.expected_date,
                              create_at = rq.create_at,
                              update_at = rq.update_at,
                          };

            if (rqModel == null)
            {
                return NotFound();
            }

            return Ok(await rqModel.ToListAsync());

        }

        [HttpPost]
        [Route("checkAppointment")]
        public async Task<IActionResult> checkAppointment([FromBody] dynamic data)
        {
            int donorId = data.donorId;
            int bbId = data.bbId;
            //var checkRq = from rq in _context.requestToBloodBanks where rq.bbId == bbId & rq.create_at.Date == DateTime.Today & rq.email == rqEmail select rq;//
            var checkRq = await _context.donorRequests.Include(rq => rq.donor).Include(rq => rq.bloodBank).FirstOrDefaultAsync(rqs => rqs.bbId == bbId && rqs.create_at.Date == DateTime.Today && rqs.donorId == donorId);
            if (checkRq != null)
            {
                DonationRequestModel checkDModel = new DonationRequestModel
                {
                    drId = checkRq.drId,
                    bbId = checkRq.bloodBank.bbId,
                    bbName = checkRq.bloodBank.bbName,

                    amount = checkRq.amount,
                    note = checkRq.note,

                    status = checkRq.status,

                    donorId = checkRq.donor.donorId,
                    donorName = checkRq.donor.donorName,

                    expected_date = checkRq.expected_date,
                    create_at = checkRq.create_at,
                    update_at = checkRq.update_at
                };
                return Ok(checkDModel);
            }
            else
            {
                return NoContent();
            }


        }

        [HttpGet]
        [Route("searchbybloodbank/{bbId}&{type}")]
        public async Task<IActionResult> searchbyBloodBank(int bbId, int type)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var rqModel = from rq in _context.donorRequests
                         
                          where rq.bbId == bbId & rq.status != 0
                          select new DonationRequestModelB
                          {
                              drId = rq.drId,
                              bbId = rq.bloodBank.bbId,
                              bbName = rq.bloodBank.bbName,
                              amount = rq.amount,
                              note = rq.note,
                              status = rq.status,
                              expected_date = rq.expected_date,

                              donorId = rq.donor.donorId,
                              donorName = rq.donor.donorName,
                              donorEmail = rq.donor.email,
                              donorPhone = rq.donor.phone,
                              donorAddress = rq.donor.address,
                              donordAge = rq.donor.age,
                              donorGender = rq.donor.gender,
                              donorBirthday = rq.donor.birthday,
                              donorWeight = rq.donor.weight,
                              donorStatus = rq.donor.status,
                              donorBloodId = rq.donor.blood.bloodId,
                              donorBloodName = rq.donor.blood.bloodName,

                              create_at = rq.create_at,
                              update_at = rq.update_at
                          };
            if (type == 0)
            {
                rqModel = from rq in _context.donorRequests
                          where rq.bbId == bbId & rq.status == 0
                          select new DonationRequestModelB
                          {
                              drId = rq.drId,
                              bbId = rq.bloodBank.bbId,
                              bbName = rq.bloodBank.bbName,
                              amount = rq.amount,
                              note = rq.note,
                              status = rq.status,
                              expected_date = rq.expected_date,

                              donorId = rq.donor.donorId,
                              donorName = rq.donor.donorName,
                              donorEmail = rq.donor.email,
                              donorPhone = rq.donor.phone,
                              donorAddress = rq.donor.address,
                              donordAge = rq.donor.age,
                              donorGender = rq.donor.gender,
                              donorBirthday = rq.donor.birthday,
                              donorWeight = rq.donor.weight,
                              donorStatus = rq.donor.status,
                              donorBloodId = rq.donor.blood.bloodId,
                              donorBloodName = rq.donor.blood.bloodName,

                              create_at = rq.create_at,
                              update_at = rq.update_at
                          };
            }
            if (rqModel == null)
            {
                return NotFound();
            }

            return Ok(await rqModel.ToListAsync());

        }

        [HttpGet]
        [Route("confirm/{rqIds}&{type}")]
        public async Task<IActionResult> Confirm(int rqIds, int type)
        {
            var donationRequest = await _context.donorRequests.FindAsync(rqIds);

            if (rqIds != donationRequest.drId)
            {
                return BadRequest();
            }
            donationRequest.status = type;
            donationRequest.update_at = DateTime.Now;
            _context.Entry(donationRequest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DonationRequestExists(rqIds))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            var list = from rq in _context.donorRequests
                       where rq.bbId == donationRequest.bbId & rq.status == 0
                       select new DonationRequestModelB
                       {
                           drId = rq.drId,
                           bbId = rq.bloodBank.bbId,
                           bbName = rq.bloodBank.bbName,
                           amount = rq.amount,
                           note = rq.note,
                           status = rq.status,
                           expected_date = rq.expected_date,

                           donorId = rq.donor.donorId,
                           donorName = rq.donor.donorName,
                           donorEmail = rq.donor.email,
                           donorPhone = rq.donor.phone,
                           donorAddress = rq.donor.address,
                           donordAge = rq.donor.age,
                           donorGender = rq.donor.gender,
                           donorBirthday = rq.donor.birthday,
                           donorWeight = rq.donor.weight,
                           donorStatus = rq.donor.status,
                           donorBloodId = rq.donor.blood.bloodId,
                           donorBloodName = rq.donor.blood.bloodName,

                           create_at = rq.create_at,
                           update_at = rq.update_at
                       };
            return Ok(list);

        }

        // PUT: api/DonationRequests/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDonationRequest([FromRoute] int id, [FromBody] DonationRequest donationRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != donationRequest.donorId)
            {
                return BadRequest();
            }

            _context.Entry(donationRequest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DonationRequestExists(id))
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

        // POST: api/DonationRequests
        [HttpPost]
        public async Task<IActionResult> PostDonationRequest([FromBody] DonationRequest donationRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.donorRequests.Add(donationRequest);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DonationRequestExists(donationRequest.drId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDonationRequest", new { id = donationRequest.drId }, donationRequest);
        }

        // DELETE: api/DonationRequests/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDonationRequest([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var donationRequest = await _context.donorRequests.FindAsync(id);
            if (donationRequest == null)
            {
                return NotFound();
            }

            _context.donorRequests.Remove(donationRequest);
            await _context.SaveChangesAsync();

            return Ok(donationRequest);
        }

        private bool DonationRequestExists(int id)
        {
            return _context.donorRequests.Any(e => e.donorId == id);
        }

        [HttpGet]
        [Route("searchName/{bbId}&{name}&{type}")]
        public async Task<IActionResult> searchname(int bbId, string name, int type)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var list = from rq in _context.donorRequests
                       where rq.bbId == bbId & rq.status != 0 & rq.donor.donorName.Contains(name)
                       select new DonationRequestModelB
                       {
                           drId = rq.drId,
                           bbId = rq.bloodBank.bbId,
                           bbName = rq.bloodBank.bbName,
                           amount = rq.amount,
                           note = rq.note,
                           status = rq.status,
                           expected_date = rq.expected_date,

                           donorId = rq.donor.donorId,
                           donorName = rq.donor.donorName,
                           donorEmail = rq.donor.email,
                           donorPhone = rq.donor.phone,
                           donorAddress = rq.donor.address,
                           donordAge = rq.donor.age,
                           donorGender = rq.donor.gender,
                           donorBirthday = rq.donor.birthday,
                           donorWeight = rq.donor.weight,
                           donorStatus = rq.donor.status,
                           donorBloodId = rq.donor.blood.bloodId,
                           donorBloodName = rq.donor.blood.bloodName,

                           create_at = rq.create_at,
                           update_at = rq.update_at
                       };
            if (type == 0)
            {
                list = from rq in _context.donorRequests
                       where rq.bbId == bbId & rq.status == 0 & rq.donor.donorName.Contains(name)
                       select new DonationRequestModelB
                       {
                           drId = rq.drId,
                           bbId = rq.bloodBank.bbId,
                           bbName = rq.bloodBank.bbName,
                           amount = rq.amount,
                           note = rq.note,
                           status = rq.status,
                           expected_date = rq.expected_date,

                           donorId = rq.donor.donorId,
                           donorName = rq.donor.donorName,
                           donorEmail = rq.donor.email,
                           donorPhone = rq.donor.phone,
                           donorAddress = rq.donor.address,
                           donordAge = rq.donor.age,
                           donorGender = rq.donor.gender,
                           donorBirthday = rq.donor.birthday,
                           donorWeight = rq.donor.weight,
                           donorStatus = rq.donor.status,
                           donorBloodId = rq.donor.blood.bloodId,
                           donorBloodName = rq.donor.blood.bloodName,

                           create_at = rq.create_at,
                           update_at = rq.update_at
                       };
            }
            if (list == null)
            {
                return NotFound();
            }

            return Ok(await list.ToListAsync());

        }

    }
}