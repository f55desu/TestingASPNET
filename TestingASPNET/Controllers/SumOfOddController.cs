using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SumOfOddService;
using TestingASPNET.Pages;
using TestingASPNET.Services.SendingDataService;

namespace TestingASPNET.Controllers
{
    public class SumOfOddController : Controller
    {
        private readonly ISumOfOddService _sumOfOddService;

        public SumOfOddController(
            ISumOfOddService sumOfOddService
        )
        {
            _sumOfOddService = sumOfOddService;
        }
        
        [HttpPost]
        public IActionResult CalculateSum([FromBody] int[] numbers)
        {
            try
            {
                int result = _sumOfOddService.CalcSumOfOdd(numbers);

                return Ok(new { Sum = result });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
