using Microsoft.AspNetCore.Mvc;

namespace TestingASPNET.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public IActionResult CalculateSum([FromBody] int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return BadRequest("Array of numbers is required.");
            }

            int sum = 0;
            for (int i = 1; i < numbers.Length; i += 2)
            {
                if (numbers[i] % 2 != 0)
                {
                    sum += numbers[i];
                }
            }

            int result = Math.Abs(sum);

            return Ok(new { Sum = result });
        }
        [HttpPost]
        public IActionResult IsPalindrome([FromBody]string input)
        {
            input = input.ToLower(); // Преобразование к нижнему регистру для учета регистра букв
            int left = 0;
            int right = input.Length - 1;

            if (input == "")
            {
                return BadRequest("Array of numbers is required.");
            }

            while (left < right)
            {
                if (!char.IsLetterOrDigit(input[left]))
                {
                    left++;
                }
                else if (!char.IsLetterOrDigit(input[right]))
                {
                    right--;
                }
                else if (input[left] != input[right])
                {
                    return Ok(new { isPalindrome = false });
                }
                else
                {
                    left++;
                    right--;
                }
            }

            return Ok(new { isPalindrome = true });
        }
    }
}
