using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestDuathlon.Managers;

namespace RestDuathlon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DuathletesController : ControllerBase
    {
        private readonly DuathlonsManager _manager = new DuathlonsManager();
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<IEnumerable<Duathlete.Models.Duathlete>> Get()
        {
            var list = _manager.GetAll();
            if (list.Count == 0) return NoContent();
            return Ok(list);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Duathlete.Models.Duathlete> GetByBip(int id)
        {
            var athlete = _manager.GetByBip(id);
            if(athlete == null) return NotFound($"No Athlete with this Bip: {id}, was found");
            return Ok(athlete);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Duathlete.Models.Duathlete> Post([FromBody] Duathlete.Models.Duathlete newAthlete)
        {
            try
            {
                var athlete = _manager.Add(newAthlete);
                return Created(athlete.Bip.ToString(), athlete);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Duathlete.Models.Duathlete> Delete(int id)
        {
            try
            {
                return Ok(_manager.Delete(id));
            }
            catch
            {
                return NotFound($"No Athlete with Bip: {id} was found");
            }
        }
    }
}
