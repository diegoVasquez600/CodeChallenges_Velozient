using TwistedFizzBuzz.Library.Interfaces;
using TwistedFizzBuzz.Library.Models;

namespace TwistedFizzBuzz.Library
{
    public class FizzBuzz : FizzBuzzBase, IFizzBuzz
    {
        public List<string> GenerateFizzBuzz(int start, int end)
        {
            try
            {
                string result;
                List<string> output = new();
                for (int number = start; number <= end; number++)
                {
                    bool isMultipleOf3 = CanBeMultipleOf(number, 3);
                    bool isMultipleOf5 = CanBeMultipleOf(number, 5);
                    result = (isMultipleOf3, isMultipleOf5) switch
                    {
                        (true, true) => "FizzBuzz",
                        (true, false) => "Fizz",
                        (false, true) => "Buzz",
                        _ => number.ToString(),
                    };
                    output.Add(result);
                }
                return output;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public List<string> GenerateFizzBuzz(int[] numbers)
        {
            try
            {
                string result;
                List<string> output = new();
                foreach (var number in numbers)
                {
                    bool isMultipleOf3 = CanBeMultipleOf(number, 3);
                    bool isMultipleOf5 = CanBeMultipleOf(number, 5);
                    result = (isMultipleOf3, isMultipleOf5) switch
                    {
                        (true, true) => "FizzBuzz",
                        (true, false) => "Fizz",
                        (false, true) => "Buzz",
                        _ => number.ToString(),
                    };
                    output.Add(result);
                }
                return output;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public List<string> GenerateFizzBuzz(int start, int end, List<(int divisor, string token)> divisorTokenPairs)
        {
            try
            {
                string result;
                List<string> output = new();
                int[] divisors = divisorTokenPairs.Select(x => x.divisor).ToArray();
                string[] tokens = divisorTokenPairs.Select(x => x.token).ToArray();
                for (int number = start; number <= end; number++)
                {
                    result = GetCustomTokenDivisorOutput(number, divisors, tokens);
                    output.Add(result);
                }
                return output;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public List<string> GenerateFizzBuzz(int[] numbers, List<(int divisor, string token)> divisorTokenPairs)
        {
            try
            {
                string result;
                List<string> output = new();
                int[] divisors = divisorTokenPairs.Select(x => x.divisor).ToArray();
                string[] tokens = divisorTokenPairs.Select(x => x.token).ToArray();
                foreach (var number in numbers)
                {
                    result = GetCustomTokenDivisorOutput(number, divisors, tokens);
                    output.Add(result);
                }
                return output;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public List<string> GenerateFizzBuzz(int start, int end, APIToken token)
        {
            try
            {
                string result;
                List<string> output = new();
                int[] divisors = { token.Multiple };
                string[] tokens = { token.Word };
                for (int number = start; number <= end; number++)
                {
                    result = GetCustomTokenDivisorOutput(number, divisors, tokens);
                    output.Add(result);
                }
                return output;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
