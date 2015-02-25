using NLog;

namespace Peons.Logging.Adapters.NLog
{
    public class LogEntryLevelTranslator : ILogEntryLevelTranslator
    {
        public LogLevel Translate(LogEntryLevel level)
        {
            switch (level)
            {
                case LogEntryLevel.Trace: return LogLevel.Trace;
                case LogEntryLevel.Debug: return LogLevel.Debug;
                case LogEntryLevel.Info: return LogLevel.Info;
                case LogEntryLevel.Warn: return LogLevel.Warn;
                case LogEntryLevel.Error: return LogLevel.Error;
                case LogEntryLevel.Fatal: return LogLevel.Fatal;
                default: throw new UnrecognizedValueException<LogLevel, LogEntryLevel>(level);
            }
        }
    }
}
