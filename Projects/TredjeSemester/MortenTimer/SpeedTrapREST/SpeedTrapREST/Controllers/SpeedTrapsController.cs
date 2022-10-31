using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpeedTrapREST.Managers;
using SpeedTrapREST.Models;

namespace SpeedTrapREST.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SpeedTrapsController : Controller
    {
        private readonly SpeedTrapsManager _manager = new SpeedTrapsManager();

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<IEnumerable<SpeedTrap>> Get()
        {
            var list = _manager.GetAll();
            if (list.Count == 0) return NoContent();
            return Ok(list);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<SpeedTrap> Get(int id)
        {
            SpeedTrap record = _manager.GetById(id);
            if (record == null) return NotFound("No such record: id: " + id);
            return Ok(record);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<SpeedTrap> Post([FromBody] SpeedTrap value)
        {
            _manager.Create(value);
            return Created(value.Id.ToString(), value);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<SpeedTrap> Put(int id, [FromBody] SpeedTrap value)
        {
            try
            {
                return Ok(_manager.Update(id, value));
            }
            catch (NullReferenceException e)
            {
                return NotFound(e.Message);
            }

        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<SpeedTrap> Delete(int id)
        {
            try
            {
                return Ok(_manager.Delete(id));
            }
            catch
            {
                return NotFound($"No record with id: {id} was found");
            }

        }
    }
}
