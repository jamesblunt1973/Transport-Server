using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Transport_Server.Data;
using Transport_Server.Models;
using Transport_Server.Repository;

namespace Transport_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MechanicsController : ControllerBase
    {
        private readonly Repository<Mechanic> _repository;

        public MechanicsController(Repository<Mechanic> repository)
        {
            _repository = repository;
        }

        // GET: api/Mechanics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mechanic>>> GetAll()
        {
            return await _repository.Get();
        }

        // GET: api/Mechanics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mechanic>> GetById(int id)
        {
            var mechanic = await _repository.GetById(id);

            if (mechanic == null)
            {
                return NotFound();
            }

            return mechanic;
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Mechanic mechanic)
        {
            if (id != mechanic.Id)
            {
                return BadRequest();
            }

            
            try
            {
                await _repository.Put(mechanic);
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }

            return NoContent();
        }


        [HttpPost]
        public async Task<ActionResult<Mechanic>> Post(Mechanic mechanic)
        {
            await _repository.Add(mechanic);

            return CreatedAtAction("GetMechanic", new { id = mechanic.Id }, mechanic);
        }

        // DELETE: api/Mechanics/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Mechanic>> Delete(int id)
        {
            var mechanic = await _repository.GetById(id);
            if (mechanic == null)
            {
                return NotFound();
            }

            await _repository.Delete(id);

            return mechanic;
        }
    }
}
