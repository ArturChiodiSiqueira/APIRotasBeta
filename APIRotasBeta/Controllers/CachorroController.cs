using APIRotasBeta.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace APIRotasBeta.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CachorroController : ControllerBase
    {
        public static List<Cachorro> dogs { get; set; } = new();

        public CachorroController()
        {

        }

        [HttpGet]
        public List<Cachorro> GetDog()
        {
            return dogs;
        }

        [HttpGet("Nome/{n}", Name = "BuscaNome")]
        public Cachorro GetDogName(string n)
        {
            return dogs.Find(x => x.Nome == n);
        }

        [HttpPost]
        public ActionResult<Cachorro> AdicionaDog(Cachorro dog)
        {
            dogs.Add(dog);
            return dog;
        }
    }
}
