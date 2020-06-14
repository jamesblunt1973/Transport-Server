using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Transport_Server.Models;
using Transport_Server.Repository;

namespace Transport_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly Repository<Vehicle> _repository;

        public VehiclesController(Repository<Vehicle> repository)
        {
            _repository = repository;
        }

        [HttpGet("/vegicles")]
        public async Task<IEnumerable<Vehicle>> GetAll()
        {
            return await _repository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Vehicle>> GetById(int id)
        {
            if (id == 0)
                return BadRequest();
            return await _repository.GetById(id);
        }

        [HttpPost]
        public async Task<ActionResult<Vehicle>> Post(Vehicle vehicle)
        {
            if (vehicle == null)
                return BadRequest();
            await _repository.Add(vehicle);
            return vehicle;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Vehicle>> Put(int id,Vehicle vehicle)
        {
            if (vehicle == null)
                return NotFound();
            if (id != vehicle.Id)
                return BadRequest();

            await _repository.Put(vehicle);
            return vehicle;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Vehicle>> Delete(int id)
        {
            if (id == 0)
                return BadRequest();
            var Vehicle = await _repository.GetById(id);
            if(Vehicle ==  null)
            {
                return NotFound();
            }
            await _repository.Delete(id);
            return Vehicle;
        }
    }
}