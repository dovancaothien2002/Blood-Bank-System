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
    public class RequestToBloodBanksController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RequestToBloodBanksController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/RequestToBloodBanks
        [HttpGet]
        public IEnumerable<RequestToBloodBank> GetrequestToBloodBanks()
        {
            return _context.requestToBloodBanks.OrderBy(c => c.update_at);
        }

        // GET: api/RequestToBloodBanks/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRequestToBloodBank([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var requestToBloodBank = await _context.requestToBloodBanks.Include(rq => rq.bloodBank).Include(rq=>rq.blood).FirstOrDefaultAsync(rq => rq.rtbkId == id);

            if (requestToBloodBank == null)
            {
                return NotFound();
            }
            else
            {
                var rqModel = new RequestToBloodBankModel
                {
                    rtbkId = requestToBloodBank.rtbkId,

                    fullname = requestToBloodBank.fullname,
                    address = requestToBloodBank.address,
                    gender = requestToBloodBank.gender,
                    birthday = requestToBloodBank.birthday,
                    email = requestToBloodBank.email,
                    phone = requestToBloodBank.phone,
                    amount = requestToBloodBank.amount,
                    note = requestToBloodBank.note,
                    hospitaltreatment = requestToBloodBank.hospitaltreatment,
                    status = requestToBloodBank.status,

                    bloodId = requestToBloodBank.blood.bloodId,
                    bloodName = requestToBloodBank.blood.bloodName,

                    bbId = requestToBloodBank.bloodBank.bbId,
                    bbName = requestToBloodBank.bloodBank.bbName,

                    expected_date = requestToBloodBank.expected_date,
                    create_at = requestToBloodBank.create_at,
                    update_at = requestToBloodBank.update_at
                };

                return Ok(rqModel);
            }
        
        }

        [HttpPost]
        [Route("checkRequest")]
        public async Task<IActionResult> checkRequest([FromBody] dynamic data)
        {
            int bbId = data.bbId;
            string rqEmail = data.rqEmail;
            //var checkRq = from rq in _context.requestToBloodBanks where rq.bbId == bbId & rq.create_at.Date == DateTime.Today & rq.email == rqEmail select rq;//
            var checkRq = await _context.requestToBloodBanks.Include(rq => rq.blood).Include(rq=>rq.bloodBank).FirstOrDefaultAsync(rqs => rqs.email == rqEmail && rqs.create_at.Date == DateTime.Today && rqs.bbId == bbId);
            if (checkRq != null)
            {
                RequestToBloodBankModel checkRqModel = new RequestToBloodBankModel
                {
                    rtbkId = checkRq.rtbkId,

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

                    bloodId = checkRq.blood.bloodId,
                    bloodName = checkRq.blood.bloodName,

                    bbId = checkRq.bloodBank.bbId,
                    bbName = checkRq.bloodBank.bbName,

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
        [Route("searchbybloodbank/{bbId}&{type}")]
        public async Task<IActionResult> searchbyBloodBank(int bbId, int type)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var rqModel = from rq in _context.requestToBloodBanks orderby rq.update_at descending
                          where rq.bbId == bbId & rq.status != 0
                          select new  RequestToBloodBankModel
                          {
                              rtbkId = rq.rtbkId,

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

                              bloodId = rq.blood.bloodId,
                              bloodName = rq.blood.bloodName,

                              bbId = rq.bloodBank.bbId,
                              bbName = rq.bloodBank.bbName,

                              expected_date = rq.expected_date,
                              create_at = rq.create_at,
                              update_at = rq.update_at
                          };
            if (type == 0)
            {
                rqModel = from rq in _context.requestToBloodBanks
                          where rq.bbId == bbId & rq.status == 0
                          select new RequestToBloodBankModel
                          {
                              rtbkId = rq.rtbkId,

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

                              bloodId = rq.blood.bloodId,
                              bloodName = rq.blood.bloodName,

                              bbId = rq.bloodBank.bbId,
                              bbName = rq.bloodBank.bbName,

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

        [HttpGet]
        [Route("confirm/{rqIds}&{type}")]
        public async Task<IActionResult> Confirm(int rqIds, int type)
        {
            var requestToBloodBank = await _context.requestToBloodBanks.FindAsync(rqIds);
           
            if (rqIds != requestToBloodBank.rtbkId)
            {
                return BadRequest();
            }
            requestToBloodBank.status = type;
            requestToBloodBank.update_at = DateTime.Now;
            _context.Entry(requestToBloodBank).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RequestToBloodBankExists(rqIds))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            var list = from rq in _context.requestToBloodBanks where rq.bbId == requestToBloodBank.bbId & rq.status == 0
                       select new RequestToBloodBankModel
                       {
                           rtbkId = rq.rtbkId,

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

                           bloodId = rq.blood.bloodId,
                           bloodName = rq.blood.bloodName,

                           bbId = rq.bloodBank.bbId,
                           bbName = rq.bloodBank.bbName,

                           expected_date = rq.expected_date,
                           create_at = rq.create_at,
                           update_at = rq.update_at
                       };
            return Ok(list);

        }

        // PUT: api/RequestToBloodBanks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRequestToBloodBank([FromRoute] int id, [FromBody] RequestToBloodBank requestToBloodBank)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != requestToBloodBank.bloodId)
            {
                return BadRequest();
            }

            _context.Entry(requestToBloodBank).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RequestToBloodBankExists(id))
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

        // POST: api/RequestToBloodBanks
        [HttpPost]
        public async Task<IActionResult> PostRequestToBloodBank([FromBody] RequestToBloodBank requestToBloodBank)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.requestToBloodBanks.Add(requestToBloodBank);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RequestToBloodBankExists(requestToBloodBank.rtbkId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRequestToBloodBank", new { id = requestToBloodBank.rtbkId }, requestToBloodBank);
        }

        // DELETE: api/RequestToBloodBanks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRequestToBloodBank([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var requestToBloodBank = await _context.requestToBloodBanks.FindAsync(id);
            if (requestToBloodBank == null)
            {
                return NotFound();
            }

            _context.requestToBloodBanks.Remove(requestToBloodBank);
            await _context.SaveChangesAsync();

            return Ok(requestToBloodBank);
        }

        private bool RequestToBloodBankExists(int id)
        {
            return _context.requestToBloodBanks.Any(e => e.bloodId == id);
        }

        [HttpGet]
        [Route("searchName/{bbId}&{name}&{type}")]
        public async Task<IActionResult> searchname(int bbId,string name,int type)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var list = from rq in _context.requestToBloodBanks
                          where rq.bbId == bbId & rq.status != 0 & rq.fullname.Contains(name)
                          select new RequestToBloodBankModel
                          {
                              rtbkId = rq.rtbkId,

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

                              bloodId = rq.blood.bloodId,
                              bloodName = rq.blood.bloodName,

                              bbId = rq.bloodBank.bbId,
                              bbName = rq.bloodBank.bbName,

                              expected_date = rq.expected_date,
                              create_at = rq.create_at,
                              update_at = rq.update_at
                          };
            if (type == 0)
            {
                list = from rq in _context.requestToBloodBanks
                          where rq.bbId == bbId & rq.status == 0 & rq.fullname.Contains(name)
                       select new RequestToBloodBankModel
                          {
                              rtbkId = rq.rtbkId,

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

                              bloodId = rq.blood.bloodId,
                              bloodName = rq.blood.bloodName,

                              bbId = rq.bloodBank.bbId,
                              bbName = rq.bloodBank.bbName,

                              expected_date = rq.expected_date,
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