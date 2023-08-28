using Microsoft.AspNetCore.Mvc;
using SortingService;

namespace TestingASPNET.Controllers
{
    public class SortingController : Controller
    {
        private readonly ISortingService _sortingService;

        public SortingController(
            ISortingService sortingService
        )
        {
            _sortingService = sortingService;
        }

        [HttpPost]
        public IActionResult Sort([FromBody] int[] numbers)
        {
            try
            {
                var sortedNumbers = _sortingService.Sort(numbers);

                return Ok(new { sortedLL = sortedNumbers });
            }
            catch ( Exception e )
            {
                return BadRequest(e.Message);
            }
        }

    }
}
