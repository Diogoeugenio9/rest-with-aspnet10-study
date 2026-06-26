using Microsoft.AspNetCore.Mvc;
using RestWithASPNET10Study.Services;
using RestWithASPNET10Study.Utils;

namespace RestWithASPNET10Study.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        private readonly MathService _service;

        public MathController(MathService service)
        {
            _service = service;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var sum = _service.Sum(
                    NumberHelper.ConvertToDecimal(firstNumber),
                    NumberHelper.ConvertToDecimal(secondNumber));
                return Ok(sum);
            }
            return BadRequest("Invalid Input!");
        }

        [HttpGet("media/{firstNumber}/{secondNumber}")]
        public IActionResult Media(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var media = _service.Media(
                    NumberHelper.ConvertToDecimal(firstNumber),
                    NumberHelper.ConvertToDecimal(secondNumber)
                    );
                return Ok(media);
            }
            return BadRequest("Invalid Input");

        }

        [HttpGet("square/{number}")]
        public IActionResult Square(string number)
        {
            if (NumberHelper.IsNumeric(number))
            {
                var sqrt = _service.Square(
                    NumberHelper.ConvertToDecimal(number)
                );
                return Ok(sqrt);
            }
            return BadRequest("Invalid Input");
        }

        


    }
}