using Newtonsoft.Json;
using TwistedFizzBuzz.Library.Models;
using TwistedFizzBuzz.Library.Services.Interfaces;

namespace TwistedFizzBuzz.Library.Services
{
    internal class TokenGenerationService : ITokenGenerationService
    {
        private readonly HttpClient _client;
        public TokenGenerationService()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://rich-red-cocoon-veil.cyclic.app")
            };
        }

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
