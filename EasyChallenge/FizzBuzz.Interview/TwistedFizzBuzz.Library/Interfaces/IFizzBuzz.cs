using TwistedFizzBuzz.Library.Models;

namespace TwistedFizzBuzz.Library.Interfaces
{
    public interface IFizzBuzz
    {
        List<string> GenerateFizzBuzz(int start, int end);
        List<string> GenerateFizzBuzz(int[] numbers);
        List<string> GenerateFizzBuzz(int start, int end, List<(int divisor, string token)> divisorTokenPairs);
        List<string> GenerateFizzBuzz(int[] numbers, List<(int divisor, string token)> divisorTokenPairs);
        List<string> GenerateFizzBuzz(int start, int end, APIToken token);
    }
}
