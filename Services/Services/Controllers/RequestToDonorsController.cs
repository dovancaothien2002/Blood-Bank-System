using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.Models;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestToDonorsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RequestToDonorsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/RequestToDonors
        [HttpGet]
        public IEnumerable<RequestToDonor> GetrequestToDonors()
        {
            return _context.requestToDonors;
        }

        // GET: api/RequestToDonors/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRequestToDonor([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var requestToDonor = await _context.requestToDonors.Include(rq => rq.donor).FirstOrDefaultAsync(rq => rq.rtdId == id);

            if (requestToDonor == null)
            {
                return NotFound();
            }
            else
            {
                var rqModel = new RequestToDonorModel
                {
                    rtdId = requestToDonor.rtdId,

                    fullname = requestToDonor.fullname,
                    address = requestToDonor.address,
                    gender = requestToDonor.gender,
                    birthday = requestToDonor.birthday,
                    email = requestToDonor.email,
                    phone = requestToDonor.phone,
                    amount = requestToDonor.amount,
                    note = requestToDonor.note,
                    hospitaltreatment = requestToDonor.hospitaltreatment,
                    status = requestToDonor.status,

                    donorId = requestToDonor.donor.donorId,
                    donorName = requestToDonor.donor.donorName,

                    expected_date = requestToDonor.expected_date,
                    create_at = requestToDonor.create_at,
                    update_at = requestToDonor.update_at
                };
                return Ok(rqModel);
            }

           
        }

        [HttpPost]
        [Route("checkRequest")]
        public async Task<IActionResult> checkRequest([FromBody] dynamic data)
        {
            int donorId = data.donorId;
            string rqEmail = data.rqEmail;
            //var checkRq = from rq in _context.requestToBloodBanks where rq.bbId == bbId & rq.create_at.Date == DateTime.Today & rq.email == rqEmail select rq;//
            var checkRq = await _context.requestToDonors.Include(rq => rq.donor).FirstOrDefaultAsync(rqs => rqs.email == rqEmail && rqs.create_at.Date == DateTime.Today && rqs.donorId == donorId);
            if (checkRq != null)
            {
                RequestToDonorModel checkRqModel = new RequestToDonorModel
                {
                    rtdId = checkRq.rtdId,

                    fullname = checkRq.fullname,
                    address = checkRq.address,
                    gender = checkRq.gender,
                    birthday = checkRq.birthday,
                    email = checkRq.email,
                    phone = checkRq.phone,
                    amount = checkRq.amount,
                    note = checkRq.note,
                    hospitaltreatment = checkRq.hospitaltreatment,
                    status = checkRq.status,

                    donorId = checkRq.donor.donorId,
                    donorName = checkRq.donor.donorName,

                    expected_date = checkRq.expected_date,
                    create_at = checkRq.create_at,
                    update_at = checkRq.update_at
                };
                return Ok(checkRqModel);
            }
            else
            {
                return NoContent();
            }


        }

        [HttpGet]
        [Route("confirm/{rqIds}&{type}")]
        public async Task<IActionResult> Confirm(int rqIds, int type)
        {
            var requestToDonor = await _context.requestToDonors.FindAsync(rqIds);
           
            if (rqIds != requestToDonor.rtdId)
            {
                return BadRequest();
            }
            requestToDonor.status = type;
            requestToDonor.update_at = DateTime.Now;
            _context.Entry(requestToDonor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RequestToDonorExists(rqIds))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            var list = from rq in _context.requestToDonors where rq.status == 0 & rq.donorId == requestToDonor.donorId select new RequestToDonorModel
            {
                rtdId = rq.rtdId,

                fullname = rq.fullname,
                address = rq.address,
                gender = rq.gender,
                birthday = rq.birthday,
                email = rq.email,
                phone = rq.phone,
                amount = rq.amount,
                note = rq.note,
                hospitaltreatment = rq.hospitaltreatment,
                status = rq.status,

                donorId = rq.donor.donorId,
                donorName = rq.donor.donorName,

                expected_date = rq.expected_date,
                create_at = rq.create_at,
                update_at = rq.update_at
            };
            return Ok(list);

        }

        [HttpGet]
        [Route("searchbydonor/{donorId}&{type}")]
        public async Task<IActionResult> searchbyDonor(int donorId,int type)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var rqModel = from rq in _context.requestToDonors
                          where rq.donorId == donorId & rq.status != 0
                          select new RequestToDonorModel
                          {
                              rtdId = rq.rtdId,

                              fullname = rq.fullname,
                              address = rq.address,
                              gender = rq.gender,
                              birthday = rq.birthday,
                              email = rq.email,
                              phone = rq.phone,
                              amount = rq.amount,
                              note = rq.note,
                              hospitaltreatment = rq.hospitaltreatment,
                              status = rq.status,

                              donorId = rq.donor.donorId,
                              donorName = rq.donor.donorName,

                              expected_date = rq.expected_date,
                              create_at = rq.create_at,
                              update_at = rq.update_at
                          };
            if (type == 0)
            {
                rqModel = from rq in _context.requestToDonors
                          where rq.donorId == donorId & rq.status == 0
                          select new RequestToDonorModel
                          {
                              rtdId = rq.rtdId,

                              fullname = rq.fullname,
                              address = rq.address,
                              gender = rq.gender,
                              birthday = rq.birthday,
                              email = rq.email,
                              phone = rq.phone,
                              amount = rq.amount,
                              note = rq.note,
                              hospitaltreatment = rq.hospitaltreatment,
                              status = rq.status,

                              donorId = rq.donor.donorId,
                              donorName = rq.donor.donorName,

                              expected_date = rq.expected_date,
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

        // PUT: api/RequestToDonors/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRequestToDonor([FromRoute] int id, [FromBody] RequestToDonor requestToDonor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != requestToDonor.rtdId)
            {
                return BadRequest();
            }

            _context.Entry(requestToDonor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RequestToDonorExists(id))
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

        // POST: api/RequestToDonors
        [HttpPost]
        public async Task<IActionResult> PostRequestToDonor([FromBody] RequestToDonor requestToDonor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.requestToDonors.Add(requestToDonor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRequestToDonor", new { id = requestToDonor.rtdId }, requestToDonor);
        }

        // DELETE: api/RequestToDonors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRequestToDonor([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var requestToDonor = await _context.requestToDonors.FindAsync(id);
            if (requestToDonor == null)
            {
                return NotFound();
            }

            _context.requestToDonors.Remove(requestToDonor);
            await _context.SaveChangesAsync();

            return Ok(requestToDonor);
        }

        private bool RequestToDonorExists(int id)
        {
            return _context.requestToDonors.Any(e => e.rtdId == id);
        }

       

    }
}