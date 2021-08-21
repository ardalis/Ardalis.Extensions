namespace Ardalis.Extensions.Verification
{
    public static partial class VerificationExtensions
    {
        /// <summary>
        /// Checks if a given condition is true
        /// </summary>
        /// <param name="value">value to check is true.</param>
        /// <returns>True if value true otherwise false.</returns>
        public static bool IsTrue(this bool value) => value;
    }
}
