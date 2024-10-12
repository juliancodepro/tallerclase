using Microsoft.AspNetCore.Mvc;
using ProyectoACSyDBAR.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoACSyDBAR.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class CalculationsController : ControllerBase
    {
        //// GET: api/<CalculationsController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<CalculationsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<CalculationsController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<CalculationsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<CalculationsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}

        [HttpPost("add")]
        public IActionResult Suma([FromBody] CalculationsDTO request)
        {
            double result = request.Num1 + request.Num2;
            return Ok(result);
        }

        [HttpPost("substract")]
        public IActionResult Resta([FromBody] CalculationsDTO request)
        {
            double result = request.Num1 - request.Num2;
            return Ok(result);
        }

        [HttpPost("multiply")]
        public IActionResult Multiplicación([FromBody] CalculationsDTO request)
        {
            double result = request.Num1 * request.Num2;
            return Ok(result);
        }

        [HttpPost("divide")]
        public IActionResult División([FromBody] CalculationsDTO request)
        {
            if (request.Num2 == 0)
                return BadRequest("Escriba otro numero");
            
            double result = request.Num1 / request.Num2;
            return Ok(result);
        }
    }
}
