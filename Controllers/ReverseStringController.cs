using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReverseStringController : ControllerBase
    {
        [HttpGet("{reverse}")]
        public string Reverse(string reverse)
        {
            char[] array = reverse.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
