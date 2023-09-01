using ICDWebApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ICDWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurgicalCodeController : ControllerBase
    {
        // GET: api/<SurgicalCodeController>
        [HttpGet]
        public IEnumerable<SurgicalCode> Get()
        {
            using (var context = new IcdContext())
            { 
                return context.SurgicalCodes.ToList();
            }
        }

        // GET api/<SurgicalCodeController>/5
        [HttpGet("{icdVersion},{surgicalCode}")]
        public IEnumerable<SurgicalCode> Get(string icdVersion, string surgicalCode)
        {
            using (var context = new IcdContext())
            {
                return context.SurgicalCodes.Where(icd => icd.IcdVersion == icdVersion && icd.SurgicalProcCode == surgicalCode).ToList();
            }
        }


        // POST api/<SurgicalCodeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SurgicalCodeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SurgicalCodeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
