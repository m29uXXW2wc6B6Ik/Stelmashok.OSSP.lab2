/// <summary>
/// The Lab2 namespace.
/// </summary>
namespace Stelmashok.OSSP.Lab2
{
    /// <summary>
    /// Class SmartPhone.
    /// </summary>
    [SecondName(Name = "Mobile")]
    public class SmartPhone :APhone, IInternet
    {
        /// <summary>
        /// Calls this instance.
        /// </summary>
        public override void Call()
        {

        }


        /// <summary>
        /// Requests the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.String.</returns>
        public string Request(string input)
        {
            return Number + " " + input;
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public string Value { get; set; }
    }
}
