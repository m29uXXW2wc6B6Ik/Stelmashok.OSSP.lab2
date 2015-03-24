/// <summary>
/// The Lab2 namespace.
/// </summary>
namespace Stelmashok.OSSP.Lab2
{
    /// <summary>
    /// Class APhone.
    /// </summary>
    [SecondName(Name = "AbstractPhone")]
    public abstract class APhone
    {
        /// <summary>
        /// Gets the phone number.
        /// </summary>
        public string Number { get; private set; }

        /// <summary>
        /// Calls this instance.
        /// </summary>
        public abstract void Call();
    }
}
