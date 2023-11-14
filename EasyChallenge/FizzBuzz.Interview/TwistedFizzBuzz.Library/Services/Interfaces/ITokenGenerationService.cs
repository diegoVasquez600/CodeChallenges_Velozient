using TwistedFizzBuzz.Library.Models;

namespace TwistedFizzBuzz.Library.Services.Interfaces
{
    internal interface ITokenGenerationService
    {
        public Task<APIToken> GenerateRandomTokenAsync();
    }
}
