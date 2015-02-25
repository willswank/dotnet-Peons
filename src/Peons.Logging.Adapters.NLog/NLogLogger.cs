using NLog;
using System;

namespace Peons.Logging.Adapters.NLog
{
    public class NLogLogger : ILogger
    {
        private readonly Logger logger;
        private readonly ILogEntryLevelTranslator levelTranslator;

        public NLogLogger(Logger logger, ILogEntryLevelTranslator levelTranslator)
        {
            this.logger = logger;
            this.levelTranslator = levelTranslator;
        }

        public void Log(LogEntryLevel level, string message)
        {
            var nativeLevel = this.levelTranslator.Translate(level);
            logger.Log(nativeLevel, message);
        }

        public void Log(LogEntryLevel level, string format, object arg0)
        {
            var nativeLevel = this.levelTranslator.Translate(level);
            logger.Log(nativeLevel, () => string.Format(format, arg0));
        }

        public void Log(LogEntryLevel level, string format, object arg0, object arg1)
        {
            var nativeLevel = this.levelTranslator.Translate(level);
            logger.Log(nativeLevel, () => string.Format(format, arg0, arg1));
        }

        public void Log(LogEntryLevel level, string format, object arg0, object arg1, object arg2)
        {
            var nativeLevel = this.levelTranslator.Translate(level);
            logger.Log(nativeLevel, () => string.Format(format, arg0, arg1, arg2));
        }

        public void Log(LogEntryLevel level, string format, params object[] args)
        {
            var nativeLevel = this.levelTranslator.Translate(level);
            logger.Log(nativeLevel, format, args);
        }

        public void Log(LogEntryLevel level, Func<string> messageGenerator)
        {
            var nativeLevel = this.levelTranslator.Translate(level);
            logger.Log(nativeLevel, messageGenerator);
        }

        public void LogException<TException>(LogEntryLevel level, TException exception) where TException : Exception
        {
            var nativeLevel = this.levelTranslator.Translate(level);
            logger.Log(nativeLevel, exception);
        }

        public void LogException<TException>(LogEntryLevel level, TException exception, string message) where TException : Exception
        {
            var nativeLevel = this.levelTranslator.Translate(level);
            logger.Log(nativeLevel, message, exception);
        }

        public void LogException<TException>(LogEntryLevel level, TException exception, string format, object arg0) where TException : Exception
        {
            var nativeLevel = this.levelTranslator.Translate(level);
            var message = string.Format(format, arg0);
            logger.Log(nativeLevel, message, exception);
        }

        public void LogException<TException>(LogEntryLevel level, TException exception, string format, object arg0, object arg1) where TException : Exception
        {
            var nativeLevel = this.levelTranslator.Translate(level);
            var message = string.Format(format, arg0, arg1);
            logger.Log(nativeLevel, message, exception);
        }

        public void LogException<TException>(LogEntryLevel level, TException exception, string format, object arg0, object arg1, object arg2) where TException : Exception
        {
            var nativeLevel = this.levelTranslator.Translate(level);
            var message = string.Format(format, arg0, arg1, arg2);
            logger.Log(nativeLevel, message, exception);
        }

        public void LogException<TException>(LogEntryLevel level, TException exception, string format, params object[] args) where TException : Exception
        {
            var nativeLevel = this.levelTranslator.Translate(level);
            var message = string.Format(format, args);
            logger.Log(nativeLevel, message, exception);
        }

        public void LogException<TException>(LogEntryLevel level, TException exception, Func<string> messageGenerator) where TException : Exception
        {
            var nativeLevel = this.levelTranslator.Translate(level);
            var message = messageGenerator();
            logger.Log(nativeLevel, message, exception);
        }
    }
}
