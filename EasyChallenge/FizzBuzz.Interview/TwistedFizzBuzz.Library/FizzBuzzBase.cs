using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwistedFizzBuzz.Library
{
    public class FizzBuzzBase
    {
        // public abstract void GetOutput(int start, int end);
        /// <summary>
        /// Returns true if number is a multiple of multiple parameter otherwise false
        /// </summary>
        /// <param name="number"></param>
        /// <param name="multiple"></param>
        /// <returns>bool</returns>
        internal virtual bool CanBeMultipleOf(int number, int multiple)
        {
            return (number % multiple) == 0;
        }
    }
}
