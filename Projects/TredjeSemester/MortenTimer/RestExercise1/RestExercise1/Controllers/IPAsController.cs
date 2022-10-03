
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RestExercise1.Managers;
using RestExercise1.Models;
using Microsoft.AspNetCore.Http;


namespace RestExercise1.Controllers
{
    [Route("[controller]")]
    // the controller is available on ..../api/books
    // [controller] means the name of the controller minus "Controller"
    [ApiController]
    public class IPAsController : Controller
    {
        private readonly IIPAsManager _manager;

        public IPAsController(IPAContext context)
        {
            _manager = new IPAsManager();

        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<IPA>> Get([FromQuery] string? substring, [FromQuery] double? minProof, [FromQuery] double? maxProof, [FromHeader] string? amount)
        {
            var list = _manager.GetAll(substring, minProof, maxProof);
            if (list == null) return NotFound("No such list was found");
            if (list.Count == 0) return NoContent();
            if (amount == null) return Ok(list);
            try
            {
                int amountToTake = Convert.ToInt32(amount);
                list = list.Take(amountToTake).ToList();
            }
            catch
            {
                return BadRequest("Amount skal være et helt positivt tal");
            }
            Response.Headers.Add("TotalAmount", list.Count.ToString());
            return Ok(list);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IPA> Get(int id)
        {
            IPA ipa = _manager.GetById(id);
            if (ipa == null) return NotFound("No such IPA, id: " + id);
            return Ok(ipa);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public ActionResult<IPA> Post([FromBody] IPA value)
        {
            if (_manager.GetById(value.Id) != null) return Conflict("An IPA with the given ID already exists, id: " + value.Id);
            try
            {
                value.Validate();
            }
            catch
            {
                return BadRequest("The given IPA isn't valid");
            }
            _manager.Add(value);
            return Created(value.Id.ToString(), value);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IPA> Put(int id, [FromBody] IPA value)
        {
            try
            {
                value.Validate();
            }
            catch
            {
                return BadRequest("The given IPA isn't valid");
            }
            return Ok(_manager.Update(id, value));
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IPA> Delete(int id)
        {
            if (_manager.GetById(id) == null) return BadRequest("No IPA with given Id found");
            return Ok(_manager.Delete(id));
        }
    }
}
