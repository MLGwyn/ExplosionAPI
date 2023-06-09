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
    public class ExplosionController : ControllerBase
    {
        [HttpGet("{digits}")]
        public string Explode(string digits)
        {
            char[] array = digits.ToCharArray();
            string combined = "";
            foreach (var dChar in array)
            {
                int cValue = Convert.ToInt32(dChar.ToString());
                string newStr = new string(dChar, cValue);
                combined += newStr;
            }
            return combined;
        }
    }
}
