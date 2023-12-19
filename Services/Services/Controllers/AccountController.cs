using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Models;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly AppDbContext _context;
        public AccountController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost("login")]
        public IActionResult Login([FromBody] Login model)
        {
            var user = _context.accounts.FirstOrDefault(x => x.Email == model.email &&
             x.Password == model.password);

            
            if (user != null)
            {
                var account = new Account
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Name = user.Name,
                    Email = user.Email,
                    Password = user.Password
                };



                return Ok(account);
            }
            //trả về lỗi
            return NotFound();
        }
    }
}