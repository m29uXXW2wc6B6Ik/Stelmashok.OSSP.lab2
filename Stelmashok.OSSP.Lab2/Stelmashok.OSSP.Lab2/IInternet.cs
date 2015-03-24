/// <summary>
/// The Lab2 namespace.
/// </summary>
namespace Stelmashok.OSSP.Lab2
{
    /// <summary>
    /// Interface IInternet
    /// </summary>
    [SecondName(Name = "InterfaceInternet")]
    public interface IInternet
    {
        /// <summary>
        /// Requests the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.String.</returns>
        string Request(string input);

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        string Value { get; set; }
    }
}
