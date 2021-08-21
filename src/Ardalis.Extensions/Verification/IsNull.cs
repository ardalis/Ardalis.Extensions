namespace Ardalis.Extensions.Verification
{
    public static partial class VerificationExtensions
    {
        /// <summary>
        /// Checks if a given object is null or not.
        /// </summary>
        /// <param name="value">value to check if it null or not.</param>
        /// <returns>True if value is null otherwise false.</returns>
        public static bool IsNull(this object value) =>
             (value == null) ? true : false;
    }
}
