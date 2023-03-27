using DKRREST.Models;
using DKRREST.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DKRREST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicRsController : ControllerBase
    {
        private readonly MusicRsRepository record = new MusicRsRepository();

        public MusicRsController(MusicRsRepository record)
        {
            this.record = record;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MusicRecord>> GetAll([FromQuery] string? title)
        {
            return record.GetAll(title);
        }

        [HttpGet("{id}")]
        public MusicRecord? Get(int id)
        {
            return record.GetById(id);
        }

        [HttpPost]
        public MusicRecord? Post([FromBody] MusicRecord newRecord)
        {
            return record.Add(newRecord);
        }

        [HttpPut("{id}")]
        public ActionResult<MusicRecord?> Put(int id, [FromBody] MusicRecord update)
        {
            return record.Update(id, update);
        }

        // DELETE api/<PokemonsController>/5
        [HttpDelete("{id}")]
        public ActionResult<MusicRecord?> Delete(int id)
        {
            MusicRecord? deleteR = record.GetById(id);
            string deleteRTitle = deleteR.Title;
            record.Delete(id);
            return Ok($"{deleteRTitle} was deleted");
        }
    }
}