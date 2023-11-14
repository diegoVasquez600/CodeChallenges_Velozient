namespace TwistedFizzBuzz.Library.Models
{
    /// <summary>
    /// Represents an API-generated token containing a numeric multiple and its corresponding word representation.
    /// </summary>
    public class APIToken
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIToken"/> class with the specified multiple and word.
        /// </summary>
        /// <param name="multiple">The numeric multiple associated with the token.</param>
        /// <param name="word">The word representation associated with the token.</param>
        public APIToken(int multiple, string word)
        {
            Multiple = multiple;
            Word = word;
        }

        /// <summary>
        /// Gets or sets the numeric multiple associated with the token.
        /// </summary>
        public int Multiple { get; set; }
        /// <summary>
        /// Gets or sets the word representation associated with the token.
        /// </summary>
        public string Word { get; set; }

    }
}
