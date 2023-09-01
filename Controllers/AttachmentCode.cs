using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ICDWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttachmentCode : ControllerBase
    {
        // GET: api/<AttachmentCode>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AttachmentCode>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AttachmentCode>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AttachmentCode>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AttachmentCode>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
