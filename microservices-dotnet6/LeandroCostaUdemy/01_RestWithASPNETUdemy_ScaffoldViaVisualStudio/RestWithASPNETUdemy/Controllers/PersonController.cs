using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet("soma/{firstNumber}/{secondNumber}")]
        public IActionResult GetSoma(string firstNumber, string secondNumber)
        {
            return BadRequest("Entrada Invalida");
        }  

    }
}