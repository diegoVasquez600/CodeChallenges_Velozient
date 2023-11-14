using TwistedFizzBuzz.Library.Interfaces;
using TwistedFizzBuzz.Library.Models;

namespace TwistedFizzBuzz.Library
{
    public class FizzBuzz : FizzBuzzBase, IFizzBuzz
    {
        /// <summary>
        /// Generates a FizzBuzz sequence for a specified range of numbers.
        /// </summary>
        /// <param name="start">The starting integer of the sequence.</param>
        /// <param name="end">The ending integer of the sequence.</param>
        /// <returns>
        /// A list of strings representing the FizzBuzz sequence for the specified range.
        /// </returns>
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
                HandleException(ex);
                throw;
            }
        }

        /// <summary>
        /// Generates a FizzBuzz sequence for a given array of numbers.
        /// </summary>
        /// <param name="numbers">An array of integers for which to generate the FizzBuzz sequence.</param>
        /// <returns>
        /// A list of strings representing the FizzBuzz sequence for the provided array of numbers.
        /// </returns>
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
                HandleException(ex);
                throw;
            }
        }

        /// <summary>
        /// Generates a custom tokenized sequence based on the provided range and divisor-token pairs.
        /// </summary>
        /// <param name="start">The starting integer of the sequence.</param>
        /// <param name="end">The ending integer of the sequence.</param>
        /// <param name="divisorTokenPairs">
        /// A list of tuples representing divisor-token pairs. The sequence will be processed
        /// to include tokens corresponding to numbers divisible by the specified divisors.
        /// </param>
        /// <returns>
        /// A list of strings representing the custom tokenized sequence for the specified range and divisor-token pairs.
        /// </returns>
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
                HandleException(ex);
                throw;
            }
        }

        /// <summary>
        /// Generates a custom tokenized sequence for a given array of numbers and divisor-token pairs.
        /// </summary>
        /// <param name="numbers">An array of integers for which to generate the custom tokenized sequence.</param>
        /// <param name="divisorTokenPairs">
        /// A list of tuples representing divisor-token pairs. The sequence will be processed
        /// to include tokens corresponding to numbers divisible by the specified divisors.
        /// </param>
        /// <returns>
        /// A list of strings representing the custom tokenized sequence for the provided array of numbers and divisor-token pairs.
        /// </returns>
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
                HandleException(ex);
                throw;
            }
        }

        /// <summary>
        /// Generates a custom tokenized sequence for a specified range using an API-generated token.
        /// </summary>
        /// <param name="start">The starting integer of the sequence.</param>
        /// <param name="end">The ending integer of the sequence.</param>
        /// <param name="token">
        /// An API-generated token containing a multiple value and its corresponding word representation.
        /// </param>
        /// <returns>
        /// A list of strings representing the custom tokenized sequence for the specified range and API-generated token.
        /// </returns>
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
                HandleException(ex);
                throw;
            }
        }

        /// <summary>
        /// Handles an exception by performing appropriate actions.
        /// </summary>
        /// <param name="ex">The exception to be handled.</param>
        private static void HandleException(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
