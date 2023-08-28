namespace SumOfOddService
{
    public class SumOfOddServiceClass : ISumOfOddService
    {
        public int CalcSumOfOdd(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                throw new Exception("Empty array provided");
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

            return result;
        }
    }
}