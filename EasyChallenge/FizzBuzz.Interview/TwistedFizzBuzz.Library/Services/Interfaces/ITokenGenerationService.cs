using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwistedFizzBuzz.Library.Models;

namespace TwistedFizzBuzz.Library.Services.Interfaces
{
    internal interface ITokenGenerationService
    {
        public Task<APIToken> GenerateRandomTokenAsync();
    }
}
