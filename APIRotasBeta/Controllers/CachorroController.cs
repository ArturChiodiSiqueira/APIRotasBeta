using APIRotasBeta.Models;
using APIRotasBeta.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace APIRotasBeta.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CachorroController : ControllerBase
    {
        private readonly CachorroServices _cachorroService;

        //public static List<Cachorro> dogs { get; set; } = new();

        public CachorroController(CachorroServices cachorroService)
        {
            _cachorroService = cachorroService;
        }

        //[HttpGet]
        //public ActionResult<List<Cachorro>> Get() => _cachorroService.Get();

        //[HttpGet("Nome/{n}", Name = "BuscaNome")]
        //public Cachorro GetDogName(string n)
        //{
        //    return dogs.Find(x => x.Nome == n);
        //}

        //[HttpPost]
        //public ActionResult<Cachorro> AdicionaDog(Cachorro dog)
        //{
        //    dogs.Add(dog);
        //    return dog;
        //}

        [HttpGet]
        public ActionResult<List<Cachorro>> Get()
        {
            var dog = _cachorroService.Get();
            if (dog == null)
            {
                return NotFound();
            }
            return dog;
        }
        [HttpGet("Nome/{s}")]
        public ActionResult<Cachorro> GetDogName(string n)
        {
            var dog = _cachorroService.Get(n);
            if (dog == null)
            {
                return NotFound();
            }
            return dog;
        }
        [HttpPost]
        public ActionResult<Cachorro> Post(Cachorro c)
        {
            var animal = _cachorroService.Create(c);
            if (animal == null)
            {
                return NotFound();
            }
            return Ok(animal);
        }
    }
}
