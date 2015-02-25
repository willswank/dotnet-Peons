
namespace Peons.Logging
{
    /// <summary>
    /// Interface to encapsulate and wrap logging frameworks.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Logs a single log entry.
        /// </summary>
        /// <param name="entry"></param>
        void Log(LogEntry entry);
    }
}
