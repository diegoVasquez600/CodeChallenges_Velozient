using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwistedFizzBuzz.Library.Interfaces
{
    public interface IFizzBuzz
    {
        void GetOutput(int start, int end);
        //DONE: Implement Original FizzBuzz: Accept user input for a range of numbers and returns their FizzBuzz output. For example, 1-50, 1-2,000,000,000, or (-2)-(-37)
        List<string> GenerateFizzBuzz(int start, int end);
        //TODO: Implement Non-sequestian Range FizzBuzz: Accept user input of a non-sequential set of numbers and returns their FizzBuzz output. For example: -5, 6, 300, 12, 15
        List<string> GenerateFizzBuzz(int[] numbers);
    }
}
