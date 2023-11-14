using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwistedFizzBuzz.Library.Models
{
    public class APIToken
    {
        public APIToken(int multiple, string word)
        {
            Multiple = multiple;
            Word = word;
        }

        public int Multiple { get; set; }
        public string Word { get; set; }

    }
}
