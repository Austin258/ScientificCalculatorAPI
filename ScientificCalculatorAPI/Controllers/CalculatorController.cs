using Microsoft.AspNetCore.Mvc;
using System;

namespace ScientificCalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // Basic Operations
        [HttpGet("add")]
        public IActionResult Add(double num1, double num2)
        {
            double result = num1 + num2;
            return Ok(result);
        }

        [HttpGet("subtract")]
        public IActionResult Subtract(double num1, double num2)
        {
            double result = num1 - num2;
            return Ok(result);
        }

        [HttpGet("multiply")]
        public IActionResult Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            return Ok(result);
        }

        [HttpGet("divide")]
        public IActionResult Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                return BadRequest("Division by zero is not allowed.");
            }
            double result = num1 / num2;
            return Ok(result);
        }

        // Scientific Functions
        [HttpGet("sqrt")]
        public IActionResult SquareRoot(double num)
        {
            if (num < 0)
            {
                return BadRequest("Square root of a negative number is not real.");
            }
            double result = Math.Sqrt(num);
            return Ok(result);
        }

        [HttpGet("power")]
        public IActionResult Power(double baseNum, double exponent)
        {
            double result = Math.Pow(baseNum, exponent);
            return Ok(result);
        }

        [HttpGet("sin")]
        public IActionResult Sin(double angle)
        {
            double result = Math.Sin(angle * Math.PI / 180); // Angle in degrees
            return Ok(result);
        }

        [HttpGet("cos")]
        public IActionResult Cos(double angle)
        {
            double result = Math.Cos(angle * Math.PI / 180); // Angle in degrees
            return Ok(result);
        }

        [HttpGet("tan")]
        public IActionResult Tan(double angle)
        {
            double result = Math.Tan(angle * Math.PI / 180); // Angle in degrees
            return Ok(result);
        }
    }
}
    
