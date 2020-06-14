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
    public class PartsController : ControllerBase
    {
        private readonly Repository<Part> _repository;

        public PartsController(Repository<Part> repository)
        {
            _repository = repository;
        }

        // GET: api/Parts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Part>>> GetAll()
        {
            return await _repository.Get();
        }

        // GET: api/Parts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Part>> GetById(int id)
        {
            var part = await _repository.GetById(id);

            if (part == null)
            {
                return NotFound();
            }

            return part;
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Part part)
        {
            if (id != part.Id)
            {
                return BadRequest();
            }


            try
            {
                await _repository.Put(part);
            }
            catch (DbUpdateConcurrencyException)
            {
                NotFound();
            }

            return NoContent();
        }


        [HttpPost]
        public async Task<ActionResult<Part>> Post(Part part)
        {
            await _repository.Add(part);

            return CreatedAtAction("GetPart", new { id = part.Id }, part);
        }

        // DELETE: api/Parts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Part>> Delete(int id)
        {
            var part = await _repository.GetById(id);
            if (part == null)
            {
                return NotFound();
            }

            await _repository.Delete(id);

            return part;
        }
    }
}
