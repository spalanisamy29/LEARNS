using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LEARNS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value12", "value22" };
        }

        // GET api/<ValuesController>/concatenate?value1=hello&value2=world
        [HttpGet("concatenate")]
        public IActionResult Concatenate(string value1, string value2)
        {
            if (string.IsNullOrEmpty(value1) || string.IsNullOrEmpty(value2))
            {
                return BadRequest(new { error = "Both value1 and value2 parameters are required" });
            }

            var result = value1 + value2;
            return Ok(new { value1, value2, concatenated = result });
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "valuess";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
