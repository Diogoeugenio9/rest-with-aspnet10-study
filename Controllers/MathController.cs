using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNET10Study.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum);
            }
            return BadRequest("Invalid Input!");
        }

        [HttpGet("media/{firstNumber}/{secondNumber}")]
        public IActionResult Media(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var media = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber)) / 2;
                return Ok(media);
            }
            return BadRequest("Invalid Input");

        }

        [HttpGet("square/{number}")]
        public IActionResult Square(string number)
        {
            if (IsNumeric(number))
            {
                var sqrt = Math.Sqrt((double)ConvertToDecimal(number));
                return Ok(sqrt);
            }
            return BadRequest("Invalid Input");
        }

        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out decimalValue)
                )
            {
                return decimalValue;
            }
            return 0;
        }

        private bool IsNumeric(string strNumber)
        {
            decimal decimalValue;
            bool isNumber = decimal.TryParse(
                strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out decimalValue
                );
            return isNumber;
        }


    }
}