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
    public class MumblingController : ControllerBase
    {
        [HttpGet("{mumbling}")]
        public String Mumbling(string mumbling)
        {
            char[] array = mumbling.ToCharArray();
            string sArr = "";
            for (int i = 0; i < array.Length; i++)
            {
                string newStr = new string(array[i], i + 1);
                newStr = char.ToUpper(newStr[0]) + (newStr.Substring(1).ToLower());
                if (newStr.Length > 1)
                    newStr = ('-') + newStr;
                sArr += newStr;
            }
            return sArr;
        }
    }
}
