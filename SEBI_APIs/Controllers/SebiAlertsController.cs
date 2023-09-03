using Microsoft.AspNetCore.Mvc;
using SEBI_APIs.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SEBI_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SebiAlertsController : ControllerBase
    {
        // GET: api/<SebiAlertsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SebiAlertsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SebiAlertsController>
        [HttpPost]
        public IActionResult Post([FromBody] SebiAlertsRequest sebiAlertsRequest)
        {
            return Ok(sebiAlertsRequest);
        }

        // PUT api/<SebiAlertsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SebiAlertsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
