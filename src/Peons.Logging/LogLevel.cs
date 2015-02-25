
namespace Peons.Logging
{
    public enum LogLevel
    {
        /// <summary>
        /// Log level to provide trace level information. Typically used during development.
        /// Contains verbose output.
        /// </summary>
        Trace = 0,

        /// <summary>
        /// Log level used for debugging.
        /// </summary>
        Debug = 1,

        /// <summary>
        /// Log level used for information purposes.
        /// </summary>
        Info = 2,

        /// <summary>
        /// Log level for potential problems.
        /// </summary>
        Warn = 3,

        /// <summary>
        /// Log level for definitive errors.
        /// </summary>
        Error = 4,

        /// <summary>
        /// Log level for severe errors...usually un-recoverable.
        /// </summary>
        Fatal = 5
    }
}
