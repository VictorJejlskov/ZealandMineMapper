﻿using FootballRESTService.Managers;
using MandatoryAssignment;
using Microsoft.AspNetCore.Mvc;

namespace FootballRESTService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FootballPlayersController : Controller
    {
        private readonly FootballPlayersManager _manager = new FootballPlayersManager();

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<FootballPlayer>> Get()
        {
            var list = _manager.GetAll();
            if (list == null) return NotFound("No such list was found");
            if (list.Count == 0) return NoContent();
            return Ok(list);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<FootballPlayer> Get(int id)
        {
            FootballPlayer player = _manager.GetById(id);
            if (player == null) return NotFound("No such player: id: " + id);
            return player;
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public ActionResult<FootballPlayer> Post([FromBody] FootballPlayer value)
        {
            try
            {
                value.Validate();
            }
            catch
            {
                return BadRequest("The given data is invalid");
            }
            if (_manager.GetAll().Exists(player => player.ShirtNumber == value.ShirtNumber)) return Conflict("A player with this shirtnumber already exists");
            _manager.Add(value);
            return Created(value.Id.ToString(), value);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public ActionResult<FootballPlayer> Put(int id, [FromBody] FootballPlayer value)
        {
            try
            {
                return Ok(_manager.Update(id, value));
            }
            catch(NullReferenceException e)
            {
                return NotFound(e.Message);
            }
            catch(ArgumentException e)
            {
                return Conflict(e.Message);
            }
            catch
            {
                return BadRequest("The given data is invalid");
            }
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<FootballPlayer> Delete(int id)
        {
            try
            {
                return Ok(_manager.Delete(id));
            }
            catch 
            {
                return NotFound($"No athlete with Bip: {id} was found");
            }

        }
    }
}
