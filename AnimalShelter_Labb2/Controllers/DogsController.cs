using AnimalShelter_Labb2.Entities;
using AnimalShelter_Labb2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;

namespace AnimalShelter_Labb2.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class DogsController : ControllerBase
    {
        private readonly IShelterRepository _shelterRepository;

        public DogsController(IShelterRepository shelterRepository)
        {
            _shelterRepository = shelterRepository;
        }


        [HttpGet]
        public IActionResult GetAllDogs() => new JsonResult(_shelterRepository.GetAllDogs());


        [HttpGet("{id}")]
        public IActionResult GetDog(int id)
        {
            var dog = _shelterRepository.GetDog(id);
            if (dog != null)
            {
                return new JsonResult(dog);
            }


            else { return NotFound($"Dog with id {id} was sadly not found"); }
        }

        [HttpPost]
        public IActionResult AddDog(Dog d)
        {
            Dog dog = new()
            {
                Id = d.Id,
                Name = d.Name
            };
            if (_shelterRepository.AddDog(dog))
            {
                return GetAllDogs();
            }
            else { return StatusCode(403); }
        }

       [HttpDelete("{id}")]
        public IActionResult DeleteDog(int id)
        {

            if (_shelterRepository.DeleteDog(id))
            {
                return GetAllDogs();
            }
            else { return StatusCode(403); }
        }

      [HttpPut("{id}")]

        public IActionResult UpdateDog(int id, string name)
        {

            if (_shelterRepository.UpdateDog(id,name))
            {
                return GetAllDogs();
            }
            else { return StatusCode(403); }
        }
        
    }


}
