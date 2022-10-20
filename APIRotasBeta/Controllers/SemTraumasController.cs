using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIRotasBeta.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SemTraumasController : ControllerBase
    {
        public SemTraumasController()
        {

        }

        [HttpGet]
        public string HelloWorld() => "Hello World!";

        [HttpGet("{nome}")]
        public string HelloWorld(string s) => s;

        [HttpPost("Hello/{n}")]
        public string HelloWorldName(string n) => $"Hello World, {n}";

        [HttpPost("Bye/{n}")]
        public string HelloWorldBye(string n) => $"Bye World, {n}";
    }
}
