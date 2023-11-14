using TwistedFizzBuzz.Library.Models;

namespace TwistedFizzBuzz.Library.Interfaces
{
    public interface IFizzBuzz
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        List<string> GenerateFizzBuzz(int start, int end);
        //DONE: Implement Non-sequestian Range FizzBuzz: Accept user input of a non-sequential set of numbers and returns their FizzBuzz output. For example: -5, 6, 300, 12, 15
        List<string> GenerateFizzBuzz(int[] numbers);
        //DONE: Implement with alternative tokens and divisors: Accept user input for alternative tokens instead of "Fizz" and "Buzz" and alternative divisors instead of 3 and 5. For example, 7, 17, and 3 would use "Poem", "Writer", and "College". 119 would output "PoemWriter", 51 would output "WriterCollege", 21 would output "PoemCollege, and 357 would output "PoemWriterCollege"
        List<string> GenerateFizzBuzz(int start, int end, List<(int divisor, string token)> divisorTokenPairs);
        List<string> GenerateFizzBuzz(int[] numbers, List<(int divisor, string token)> divisorTokenPairs);
        List<string> GenerateFizzBuzz(int start, int end, APIToken token);
    }
}
