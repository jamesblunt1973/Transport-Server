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
    public class ServicesController : ControllerBase
    {
        private readonly Repository<Service> _repository;

        public ServicesController(Repository<Service> repository)
        {
            _repository = repository;
        }

        // GET: api/Services
        [HttpGet("/services")]
        public async Task<ActionResult<IEnumerable<Service>>> GetAll()
        {
            return await _repository.Get();
        }

        // GET: api/Services/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Service>> GetById(int id)
        {
            var service = await _repository.GetById(id);

            if (service == null)
            {
                return NotFound();
            }

            return service;
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Service service)
        {
            if (id != service.Id)
            {
                return BadRequest();
            }

            try
            {
                await _repository.Put(service);
            }

            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }

            return NoContent();
        }


        [HttpPost]
        public async Task<ActionResult<Service>> Post(Service service)
        {
            await _repository.Add(service);
            return CreatedAtAction("GetService", new { id = service.Id }, service);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<Service>> Delete(int id)
        {
            var service = await _repository.GetById(id);
            if (service == null)
            {
                return NotFound();
            }

            await _repository.Delete(id);
            return service;
        }
    }
}
