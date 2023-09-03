using Microsoft.AspNetCore.Mvc;
using SEBI_APIs.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SEBI_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LearnController : ControllerBase
    {
        // GET: api/<LearnController>
        [HttpGet]
        public IEnumerable<Learn> Get()
        {
            List<Learn> learn = new List<Learn>();
            learn.Add(new Learn());
            return learn;
            //return new string[] { "value1", "value2" };
        }

        //// GET api/<LearnController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<LearnController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<LearnController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<LearnController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
