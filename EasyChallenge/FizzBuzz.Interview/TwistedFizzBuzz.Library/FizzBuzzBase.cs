using TwistedFizzBuzz.Library.Models;
using TwistedFizzBuzz.Library.Services;

namespace TwistedFizzBuzz.Library
{
    /// <summary>
    /// Base class for FizzBuzz implementations.
    /// </summary>
    public class FizzBuzzBase
    {
        /// <summary>
        /// Determines whether a given number is a multiple of a specified factor.
        /// </summary>
        /// <param name="number">The integer to be checked for being a multiple.</param>
        /// <param name="multiple">The factor to check against.</param>
        /// <returns>
        ///   <c>true</c> if the <paramref name="number"/> is a multiple of the <paramref name="multiple"/> parameter;
        ///   otherwise, <c>false</c>.
        /// </returns>
        internal virtual bool CanBeMultipleOf(int number, int multiple) => (number % multiple) == 0;
        
        /// <summary>
        /// Generates a custom tokenized output based on whether the given number is a multiple
        /// of specified factors, using corresponding tokens.
        /// </summary>
        /// <param name="number">The integer to be checked and processed.</param>
        /// <param name="multiples">An array of integers representing the factors to check against.</param>
        /// <param name="tokens">An array of strings representing the tokens corresponding to the factors.</param>
        /// <returns>
        /// A string composed of tokens associated with factors for which the <paramref name="number"/> is a multiple.
        /// If no factors match, the method returns the string representation of the original <paramref name="number"/>.
        /// </returns>
        public virtual string GetCustomTokenDivisorOutput(int number, int[] multiples, string[] tokens)
        {
            try
            {
                string result = "";
                for (int index = 0; index < multiples.Length; index++)
                {
                    if (CanBeMultipleOf(number, multiples[index]))
                    {
                        result += tokens[index];
                    }
                }
                if (result == "")
                {
                    result = number.ToString();
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        /// <summary>
        /// Asynchronously retrieves an API-generated token.
        /// </summary>
        /// <returns>
        /// A task representing the asynchronous operation. The task result contains the retrieved API token.
        /// </returns>
        public virtual async Task<APIToken> GetAPIGeneratedTokenAsync()
        {
            try
            {
                TokenGenerationService tokenGenerationService = new();
                APIToken token = await tokenGenerationService.GenerateRandomTokenAsync();
                return token;
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);
                throw;
            }
        }
    }
}
