using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RESTAPI.Controllers
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

        [HttpGet("sum/{firstnumber}/{secondnumber}")]
        public IActionResult Sum(string firstnumber, string secondnumber)
        {
            if(IsNumeric(firstnumber) && IsNumeric(secondnumber))
            {
                var sum = ConvertToDecimal(firstnumber) + ConvertToDecimal(secondnumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid value");
        }

        [HttpGet("sub/{firstnumber}/{secondnumber}")]
        public IActionResult Subtraction(string firstnumber, string secondnumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondnumber))
            {
                var sub = ConvertToDecimal(firstnumber) - ConvertToDecimal(secondnumber);
                return Ok(sub.ToString());
            }
            return BadRequest("Invalid value");
        }

        [HttpGet("mult/{firstnumber}/{secondnumber}")]
        public IActionResult Multiplication(string firstnumber, string secondnumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondnumber))
            {
                var mult = ConvertToDecimal(firstnumber) * ConvertToDecimal(secondnumber);
                return Ok(mult.ToString());
            }
            return BadRequest("Invalid value");
        }

        [HttpGet("div/{firstnumber}/{secondnumber}")]
        public IActionResult Division(string firstnumber, string secondnumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondnumber))
            {
                var div = ConvertToDecimal(firstnumber) / ConvertToDecimal(secondnumber);
                return Ok(div.ToString());
            }
            return BadRequest("Invalid value");
        }

        [HttpGet("med/{firstnumber}/{secondnumber}")]
        public IActionResult Media(string firstnumber, string secondnumber)
        {
            if (IsNumeric(firstnumber) && IsNumeric(secondnumber))
            {
                var med = (ConvertToDecimal(firstnumber) + ConvertToDecimal(secondnumber))/2;
                return Ok(med.ToString());
            }
            return BadRequest("Invalid value");
        }

        [HttpGet("sqrt/{firstnumber}")]
        public IActionResult SquareRoot(string firstnumber)
        {
            if (IsNumeric(firstnumber))
            {
                var sqrt = Math.Sqrt((double)ConvertToDecimal(firstnumber)) ;
                return Ok(sqrt.ToString());
            }
            return BadRequest("Invalid value");
        }



        private bool IsNumeric(string strnumber)
        {
            double number;
            bool isNumber = double.TryParse(
                strnumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number);
            return isNumber;

        }

        private decimal ConvertToDecimal(string strnumber)
        {
            decimal decimalValue;
            if(decimal.TryParse(strnumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

        
    }
}
