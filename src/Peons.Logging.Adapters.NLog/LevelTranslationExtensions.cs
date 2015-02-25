using NLOG_LEVEL = global::NLog.LogLevel;

namespace Peons.Logging.Adapters.NLog
{
    public static class LevelTranslationExtensions
    {
        public static NLOG_LEVEL Translate(this LogLevel level)
        {
            switch (level)
            {
                case LogLevel.Trace: return NLOG_LEVEL.Trace;
                case LogLevel.Debug: return NLOG_LEVEL.Debug;
                case LogLevel.Info: return NLOG_LEVEL.Info;
                case LogLevel.Warn: return NLOG_LEVEL.Warn;
                case LogLevel.Error: return NLOG_LEVEL.Error;
                case LogLevel.Fatal: return NLOG_LEVEL.Fatal;
                default: throw new UnrecognizedValueException<NLOG_LEVEL, LogLevel>(level);
            }
        }
    }
}
