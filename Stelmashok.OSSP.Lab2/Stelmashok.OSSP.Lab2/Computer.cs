/// <summary>
/// The Lab2 namespace.
/// </summary>
namespace Stelmashok.OSSP.Lab2
{
    /// <summary>
    /// Class Computer.
    /// </summary>
    [SecondName(Name = "Device")]
    public class Computer : IInternet
    {
        /// <summary>
        /// Requests the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.String.</returns>
        public string Request(string input)
        {
            return input;
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public string Value { get; set; }
    }
}
