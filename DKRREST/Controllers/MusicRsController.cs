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
        public IEnumerable<MusicRecord> GetAll()
        {
            return record.GetAll();
        }

        [HttpGet("{id}")]
        public MusicRecord? Get(int id)
        {
            return record.GetById(id);
        }
    }
}