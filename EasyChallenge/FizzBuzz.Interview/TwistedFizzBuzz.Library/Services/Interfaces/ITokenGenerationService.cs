using TwistedFizzBuzz.Library.Models;

namespace TwistedFizzBuzz.Library.Services.Interfaces
{
    /// <summary>
    /// Interface for a service responsible for generating API tokens asynchronously.
    /// </summary>
    internal interface ITokenGenerationService
    {
        /// <summary>
        /// Asynchronously generates a random API token.
        /// </summary>
        /// <returns>
        /// A task representing the asynchronous operation. The task result contains the generated API token.
        /// </returns>
        public Task<APIToken> GenerateRandomTokenAsync();
    }
}
