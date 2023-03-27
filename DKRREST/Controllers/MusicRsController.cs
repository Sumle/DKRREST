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
        public ActionResult <IEnumerable<MusicRecord>> GetAll([FromQuery] string? title)
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
    }
}