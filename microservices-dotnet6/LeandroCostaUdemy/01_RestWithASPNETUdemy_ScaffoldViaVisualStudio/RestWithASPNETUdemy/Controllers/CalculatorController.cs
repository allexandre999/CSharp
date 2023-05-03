using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("soma/{firstNumber}/{secondNumber}")]
        public IActionResult GetSoma(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber)) 
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Entrada Invalida");
        }

        [HttpGet("subtracao/{firstnumber}/{secondNumber}")]
        public IActionResult GetSubtracao(string firstnumber, string secondNumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondNumber))
            {
                var subtracao = ConvertToDecimal(firstnumber) - ConvertToDecimal(secondNumber);
                return Ok(subtracao.ToString());
            }

            return BadRequest("Entrada Invalida");
        }

        [HttpGet("multiplicacao/{firstnumber}/{secondNumber}")]
        public IActionResult GetMultiplicacao(string firstnumber, string secondNumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondNumber))
            {
                var multiplicacao = ConvertToDecimal(firstnumber) * ConvertToDecimal(secondNumber);
                return Ok(multiplicacao.ToString());
            }

            return BadRequest("Entrada Invalida");
        }

        [HttpGet("divisao/{firstnumber}/{secondNumber}")]
        public IActionResult GetDivisao(string firstnumber, string secondNumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondNumber))
            {
                var divisao = ConvertToDecimal(firstnumber) / ConvertToDecimal(secondNumber);
                return Ok(divisao.ToString());
            }

            return BadRequest("Entrada Invalida");
        }

        private decimal ConvertToDecimal(string strtNumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(strtNumber, out decimalValue)) 
            {
                return decimalValue;
            }
            return 0;
        }

        private bool IsNumeric(string strtNumber)
        {
            double number;
            bool isNumber = double.TryParse(
                strtNumber, 
                System.Globalization.NumberStyles.Any, 
                System.Globalization.NumberFormatInfo.InvariantInfo, 
                out number);
            return isNumber;
        }
    }
}