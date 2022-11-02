using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PairProgrammingRestJS.Managers;
using PairProgrammingRestJS.Models;

namespace PairProgrammingRestJS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicRecordsController : ControllerBase
    {
        private readonly MusicRecordsManager _musicRecordsManager = new MusicRecordsManager();

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<MusicRecord>> Get()
        {
            List<MusicRecord> list = _musicRecordsManager.GetAll();
            if(list == null) return NotFound($"No list was found, should never happen.");
            return Ok(list);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<MusicRecord> Get(int id)
        {
            MusicRecord musicRecord = _musicRecordsManager.GetById(id);
            if (musicRecord == null) return NotFound($"No record with id: {id}, was found");
            return Ok(musicRecord);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<MusicRecord> Post([FromBody] MusicRecord value)
        {
            MusicRecord record = _musicRecordsManager.Add(value);
            return Created(record.Id.ToString(), record);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<MusicRecord> Put([FromBody] MusicRecord value, int id)
        {
            MusicRecord musicRecord = _musicRecordsManager.Update(value, id);
            if (musicRecord == null) return NotFound($"No record with id: {id}, was found");
            return Ok(musicRecord);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<MusicRecord> Delete(int id)
        {
            MusicRecord musicRecord = _musicRecordsManager.Delete(id);
            if(musicRecord == null) return NotFound($"No record with id: {id}, was found");
            return Ok(musicRecord);
        }
    }
}
