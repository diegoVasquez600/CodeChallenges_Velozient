using Newtonsoft.Json;
using TwistedFizzBuzz.Library.Models;
using TwistedFizzBuzz.Library.Services.Interfaces;

namespace TwistedFizzBuzz.Library.Services
{
    /// <summary>
    /// Service for generating API tokens through HTTP requests.
    /// </summary>
    internal class TokenGenerationService : ITokenGenerationService
    {
        private readonly HttpClient _client;
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenGenerationService"/> class.
        /// </summary>
        public TokenGenerationService()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://rich-red-cocoon-veil.cyclic.app")
            };
        }

        /// <summary>
        /// Asynchronously generates a random API token.
        /// </summary>
        /// <returns>
        /// A task representing the asynchronous operation. The task result contains the generated API token.
        /// </returns>
        public async Task<APIToken> GenerateRandomTokenAsync()
        {
            try
            {
                var response = await _client.GetAsync("/random");
                if (response.IsSuccessStatusCode)
                {
                    APIToken? token = JsonConvert.DeserializeObject<APIToken>(await response.Content.ReadAsStringAsync());
                    if (token is not null)
                        return token;
                    else
                        throw new Exception("Unable to deserialize token");
                }
                else
                {
                    throw new Exception("Unable to generate token");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
