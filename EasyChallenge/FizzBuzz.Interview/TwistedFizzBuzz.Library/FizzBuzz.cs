using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwistedFizzBuzz.Library.Interfaces;

namespace TwistedFizzBuzz.Library
{
    public class FizzBuzz : FizzBuzzBase, IFizzBuzz
    {
        // DONE: Implement Original FizzBuzz

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
                for (int number = start; number <= end; number++)
                {
                    //DONE: Read divisorTokenPairs and use them to determine the output
                    foreach (var (divisor, token) in divisorTokenPairs)
                    {
                        bool isMultipleOfDivisor = CanBeMultipleOf(number, divisor);
                        result = isMultipleOfDivisor ? token : number.ToString();
                        output.Add(result);
                    }
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
                foreach (var number in numbers)
                {
                    //DONE: Read divisorTokenPairs and use them to determine the output
                    foreach (var (divisor, token) in divisorTokenPairs)
                    {
                        bool isMultipleOfDivisor = CanBeMultipleOf(number, divisor);
                        result = isMultipleOfDivisor ? token : number.ToString();
                        output.Add(result);
                    }
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
