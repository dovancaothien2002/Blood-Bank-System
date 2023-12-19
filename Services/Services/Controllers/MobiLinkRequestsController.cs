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
    public class MobiLinkRequestsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MobiLinkRequestsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/MobiLinkRequests
        [HttpGet]
        public IEnumerable<MobiLinkRequestModel> GetmobiLinkRequests()
        {
            var list = from rq in _context.mobiLinkRequests
                       orderby rq.update_at descending
                       select new MobiLinkRequestModel
                       {
                           mlrId = rq.mlrId,
                           fullname = rq.fullname,
                           address = rq.address,
                           bloodId = rq.blood.bloodId,
                           bloodName = rq.blood.bloodName,
                           email = rq.email,
                           expected_date = rq.expected_date,
                           create_at = rq.create_at,
                           hospitaltreatment = rq.hospitaltreatment,
                           note = rq.note,
                           phone = rq.phone,
                           status = rq.status,
                           update_at = rq.update_at

                       };
            return list;
        }

        // GET: api/MobiLinkRequests/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMobiLinkRequest([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var rq = await _context.mobiLinkRequests.Include(rqs=>rqs.blood).FirstOrDefaultAsync(rqs => rqs.mlrId == id);

            if (rq == null)
            {
                return NotFound();
            }
            else
            {
                MobiLinkRequestModel rqModel = new MobiLinkRequestModel
                {
                    mlrId = rq.mlrId,
                    fullname = rq.fullname,
                    address = rq.address,
                    bloodId = rq.blood.bloodId,
                    bloodName = rq.blood.bloodName,
                    email = rq.email,
                    expected_date = rq.expected_date,
                    create_at = rq.create_at,
                    hospitaltreatment = rq.hospitaltreatment,
                    note = rq.note,
                    phone = rq.phone,
                    status = rq.status,
                    update_at = rq.update_at

                };
                return Ok(rqModel);
            }

           
        }

        // PUT: api/MobiLinkRequests/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMobiLinkRequest([FromRoute] int id, [FromBody] MobiLinkRequest mobiLinkRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mobiLinkRequest.mlrId)
            {
                return BadRequest();
            }

            _context.Entry(mobiLinkRequest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MobiLinkRequestExists(id))
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

        // POST: api/MobiLinkRequests
        [HttpPost]
        public async Task<IActionResult> PostMobiLinkRequest([FromBody] MobiLinkRequest mobiLinkRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.mobiLinkRequests.Add(mobiLinkRequest);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMobiLinkRequest", new { id = mobiLinkRequest.mlrId }, mobiLinkRequest);
        }

        // DELETE: api/MobiLinkRequests/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMobiLinkRequest([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mobiLinkRequest = await _context.mobiLinkRequests.FindAsync(id);
            if (mobiLinkRequest == null)
            {
                return NotFound();
            }

            _context.mobiLinkRequests.Remove(mobiLinkRequest);
            await _context.SaveChangesAsync();

            return Ok(mobiLinkRequest);
        }

        private bool MobiLinkRequestExists(int id)
        {
            return _context.mobiLinkRequests.Any(e => e.mlrId == id);
        }

        [HttpGet]
        [Route("search/{name}&{status}")]
        public async Task<IActionResult> SearchName(string name,int status)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var list = from rq in _context.mobiLinkRequests
                                 where rq.fullname.Contains(name)
                                 select new MobiLinkRequestModel
                                 {
                                     mlrId = rq.mlrId,
                                     fullname = rq.fullname,
                                     address = rq.address,
                                     bloodId = rq.blood.bloodId,
                                     bloodName = rq.blood.bloodName,
                                     email = rq.email,
                                     expected_date = rq.expected_date,
                                     create_at = rq.create_at,
                                     hospitaltreatment = rq.hospitaltreatment,
                                     note = rq.note,
                                     phone = rq.phone,
                                     status = rq.status,
                                     update_at = rq.update_at

                                 };

            if(status == 1)
            {
                list = from rq in _context.mobiLinkRequests
                       where rq.fullname.Contains(name) & rq.status == 1
                       select new MobiLinkRequestModel
                       {
                           mlrId = rq.mlrId,
                           fullname = rq.fullname,
                           address = rq.address,
                           bloodId = rq.blood.bloodId,
                           bloodName = rq.blood.bloodName,
                           email = rq.email,
                           expected_date = rq.expected_date,
                           create_at = rq.create_at,
                           hospitaltreatment = rq.hospitaltreatment,
                           note = rq.note,
                           phone = rq.phone,
                           status = rq.status,
                           update_at = rq.update_at

                       };
            }
            if (list == null)
            {
                return NotFound();
            }

            return Ok(await list.ToListAsync());

        }

        [HttpGet]
        [Route("listshowed")]
        public async Task<IActionResult> list()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var list = from rq in _context.mobiLinkRequests
                       where rq.status == 1
                       select new MobiLinkRequestModel
                       {
                           mlrId = rq.mlrId,
                           fullname = rq.fullname,
                           address = rq.address,
                           bloodId = rq.blood.bloodId,
                           bloodName = rq.blood.bloodName,
                           email = rq.email,
                           expected_date = rq.expected_date,
                           create_at = rq.create_at,
                           hospitaltreatment = rq.hospitaltreatment,
                           note = rq.note,
                           phone = rq.phone,
                           status = rq.status,
                           update_at = rq.update_at

                       };


            if (list == null)
            {
                return NotFound();
            }

            return Ok(await list.ToListAsync());

        }

    }
}