namespace PalindromeService
{
    public class PalindromeServiceClass : IPalindromeService
    {
        public bool IsPalindrome(string input)
        {
            input = input.ToLower(); // Преобразование к нижнему регистру для учета регистра букв
            int left = 0;
            int right = input.Length - 1;

            if (input == "")
            {
                return false;
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
                    return false;
                }
                else
                {
                    left++;
                    right--;
                }
            }

            return true;
        }
    }
}