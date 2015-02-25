using System;

using MESSAGE_GENERATOR = System.Func<string>;

namespace Peons.Logging
{
    public static class LoggerExtensions
    {
        public static void Trace(this ILogger logger, string message)
        {
            logger.Log(LogEntryLevel.Trace, message);
        }

        public static void Trace(this ILogger logger, Exception exception)
        {
            logger.Log(LogEntryLevel.Trace, exception);
        }

        public static void Trace(this ILogger logger, string message, Exception exception)
        {
            logger.Log(LogEntryLevel.Trace, message, exception);
        }

        public static void Trace(this ILogger logger, MESSAGE_GENERATOR messageGenerator)
        {
            logger.Log(LogEntryLevel.Trace, messageGenerator);
        }

        public static void Trace(this ILogger logger, MESSAGE_GENERATOR messageGenerator, Exception exception)
        {
            logger.Log(LogEntryLevel.Trace, messageGenerator, exception);
        }

        public static void Debug(this ILogger logger, string message)
        {
            logger.Log(LogEntryLevel.Debug, message);
        }

        public static void Debug(this ILogger logger, Exception exception)
        {
            logger.Log(LogEntryLevel.Debug, exception);
        }

        public static void Debug(this ILogger logger, string message, Exception exception)
        {
            logger.Log(LogEntryLevel.Debug, message, exception);
        }

        public static void Debug(this ILogger logger, MESSAGE_GENERATOR messageGenerator)
        {
            logger.Log(LogEntryLevel.Debug, messageGenerator);
        }

        public static void Debug(this ILogger logger, MESSAGE_GENERATOR messageGenerator, Exception exception)
        {
            logger.Log(LogEntryLevel.Debug, messageGenerator, exception);
        }

        public static void Info(this ILogger logger, string message)
        {
            logger.Log(LogEntryLevel.Info, message);
        }

        public static void Info(this ILogger logger, Exception exception)
        {
            logger.Log(LogEntryLevel.Info, exception);
        }

        public static void Info(this ILogger logger, string message, Exception exception)
        {
            logger.Log(LogEntryLevel.Info, message, exception);
        }

        public static void Info(this ILogger logger, MESSAGE_GENERATOR messageGenerator)
        {
            logger.Log(LogEntryLevel.Info, messageGenerator);
        }

        public static void Info(this ILogger logger, MESSAGE_GENERATOR messageGenerator, Exception exception)
        {
            logger.Log(LogEntryLevel.Info, messageGenerator, exception);
        }

        public static void Warn(this ILogger logger, string message)
        {
            logger.Log(LogEntryLevel.Warn, message);
        }

        public static void Warn(this ILogger logger, Exception exception)
        {
            logger.Log(LogEntryLevel.Warn, exception);
        }

        public static void Warn(this ILogger logger, string message, Exception exception)
        {
            logger.Log(LogEntryLevel.Warn, message, exception);
        }

        public static void Warn(this ILogger logger, MESSAGE_GENERATOR messageGenerator)
        {
            logger.Log(LogEntryLevel.Warn, messageGenerator);
        }

        public static void Warn(this ILogger logger, MESSAGE_GENERATOR messageGenerator, Exception exception)
        {
            logger.Log(LogEntryLevel.Warn, messageGenerator, exception);
        }

        public static void Error(this ILogger logger, string message)
        {
            logger.Log(LogEntryLevel.Error, message);
        }

        public static void Error(this ILogger logger, Exception exception)
        {
            logger.Log(LogEntryLevel.Error, exception);
        }

        public static void Error(this ILogger logger, string message, Exception exception)
        {
            logger.Log(LogEntryLevel.Error, message, exception);
        }

        public static void Error(this ILogger logger, MESSAGE_GENERATOR messageGenerator)
        {
            logger.Log(LogEntryLevel.Error, messageGenerator);
        }

        public static void Error(this ILogger logger, MESSAGE_GENERATOR messageGenerator, Exception exception)
        {
            logger.Log(LogEntryLevel.Error, messageGenerator, exception);
        }

        public static void Fatal(this ILogger logger, string message)
        {
            logger.Log(LogEntryLevel.Fatal, message);
        }

        public static void Fatal(this ILogger logger, Exception exception)
        {
            logger.Log(LogEntryLevel.Fatal, exception);
        }

        public static void Fatal(this ILogger logger, string message, Exception exception)
        {
            logger.Log(LogEntryLevel.Fatal, message, exception);
        }

        public static void Fatal(this ILogger logger, MESSAGE_GENERATOR messageGenerator)
        {
            logger.Log(LogEntryLevel.Fatal, messageGenerator);
        }

        public static void Fatal(this ILogger logger, MESSAGE_GENERATOR messageGenerator, Exception exception)
        {
            logger.Log(LogEntryLevel.Fatal, messageGenerator, exception);
        }

        private static void Log(this ILogger logger, LogEntryLevel level, string message)
        {
            var entry = new LogEntry(level, message);
            logger.Log(entry);
        }

        private static void Log(this ILogger logger, LogEntryLevel level, Exception exception)
        {
            var entry = new LogEntry(level, exception);
            logger.Log(entry);
        }

        private static void Log(this ILogger logger, LogEntryLevel level, string message, Exception exception)
        {
            var entry = new LogEntry(level, message, exception);
            logger.Log(entry);
        }

        private static void Log(this ILogger logger, LogEntryLevel level, MESSAGE_GENERATOR messageGenerator)
        {
            var entry = new LogEntry(level, messageGenerator);
            logger.Log(entry);
        }

        private static void Log(this ILogger logger, LogEntryLevel level, MESSAGE_GENERATOR messageGenerator, Exception exception)
        {
            var entry = new LogEntry(level, messageGenerator, exception);
            logger.Log(entry);
        }
    }
}
