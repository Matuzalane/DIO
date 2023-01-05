using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _4_dotNET_API_com_Csharp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet("GetCurretntDateTime")]
        public IActionResult GetDateTime()
        {
            var obj = new
            {
                Date = DateTime.Now.ToLongDateString(),
                Time = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);
        }

        [HttpGet("Introduce/{name}")]
        public IActionResult Introduce(string name)
        {
            var menssage = $"Hello {name}, be welcome!";

            return Ok(new { menssage });
        }
    }
}