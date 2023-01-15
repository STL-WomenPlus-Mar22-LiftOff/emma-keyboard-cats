using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Keyboard_Cats.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetFinder : ControllerBase
    {
        // GET: api/<PetFinder>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PetFinder>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PetFinder>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PetFinder>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PetFinder>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        
    }
}
