using NLog;

namespace Peons.Logging.Adapters.NLog
{
    public interface ILogEntryLevelTranslator
    {
        LogLevel Translate(LogEntryLevel level);
    }
}
