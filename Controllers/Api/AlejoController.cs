using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuthServices.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlejoController : ControllerBase
    {

        // GET: api/<AlejoController>
        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "admin")]

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("111")]
        public IEnumerable<string> Get111()
        {
            return new string[] { "1111111", "valu2222e2" };
        }


        // GET api/<AlejoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AlejoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AlejoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AlejoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
