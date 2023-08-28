using Microsoft.AspNetCore.Mvc;
using PalindromeService;

namespace TestingASPNET.Controllers
{
    public class PalindromeController : Controller
    {
        private readonly IPalindromeService _palindromeService;

        public PalindromeController(
            IPalindromeService palindromeService
        )
        {
            _palindromeService = palindromeService;
        }

        [HttpPost]
        public IActionResult IsPalindrome([FromBody] string input)
        {
            try
            {
                var isPalindrome = _palindromeService.IsPalindrome(input);
                return Ok(new { isPalindrome = isPalindrome });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
