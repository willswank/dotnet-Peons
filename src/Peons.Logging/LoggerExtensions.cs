using System;

namespace Peons.Logging
{
    public static class LoggerExtensions
    {
        public static void Trace(this ILogger logger, string message)
        {
            logger.Log(LogEntryLevel.Trace, message);
        }

        public static void Trace(this ILogger logger, string format, object arg0)
        {
            logger.Log(LogEntryLevel.Trace, format, arg0);
        }

        public static void Trace(this ILogger logger, string format, object arg0, object arg1)
        {
            logger.Log(LogEntryLevel.Trace, format, arg0, arg1);
        }

        public static void Trace(this ILogger logger, string format, object arg0, object arg1, object arg2)
        {
            logger.Log(LogEntryLevel.Trace, format, arg0, arg1, arg2);
        }

        public static void Trace(this ILogger logger, string format, params object[] args)
        {
            logger.Log(LogEntryLevel.Trace, format, args);
        }

        public static void Trace(this ILogger logger, Func<string> messageGenerator)
        {
            logger.Log(LogEntryLevel.Trace, messageGenerator);
        }

        public static void TraceException<TException>(this ILogger logger, TException exception) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Trace, exception);
        }

        public static void TraceException<TException>(this ILogger logger, TException exception, string message) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Trace, exception, message);
        }

        public static void TraceException<TException>(this ILogger logger, TException exception, string format, object arg0) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Trace, exception, format, arg0);
        }

        public static void TraceException<TException>(this ILogger logger, TException exception, string format, object arg0, object arg1) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Trace, exception, format, arg0, arg1);
        }

        public static void TraceException<TException>(this ILogger logger, TException exception, string format, object arg0, object arg1, object arg2) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Trace, exception, format, arg0, arg1, arg2);
        }

        public static void TraceException<TException>(this ILogger logger, TException exception, string format, params object[] args) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Trace, exception, format, args);
        }

        public static void TraceException<TException>(this ILogger logger, TException exception, Func<string> messageGenerator) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Trace, exception, messageGenerator);
        }

        public static void Debug(this ILogger logger, string message)
        {
            logger.Log(LogEntryLevel.Debug, message);
        }

        public static void Debug(this ILogger logger, string format, object arg0)
        {
            logger.Log(LogEntryLevel.Debug, format, arg0);
        }

        public static void Debug(this ILogger logger, string format, object arg0, object arg1)
        {
            logger.Log(LogEntryLevel.Debug, format, arg0, arg1);
        }

        public static void Debug(this ILogger logger, string format, object arg0, object arg1, object arg2)
        {
            logger.Log(LogEntryLevel.Debug, format, arg0, arg1, arg2);
        }

        public static void Debug(this ILogger logger, string format, params object[] args)
        {
            logger.Log(LogEntryLevel.Debug, format, args);
        }

        public static void Debug(this ILogger logger, Func<string> messageGenerator)
        {
            logger.Log(LogEntryLevel.Debug, messageGenerator);
        }

        public static void DebugException<TException>(this ILogger logger, TException exception) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Debug, exception);
        }

        public static void DebugException<TException>(this ILogger logger, TException exception, string message) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Debug, exception, message);
        }

        public static void DebugException<TException>(this ILogger logger, TException exception, string format, object arg0) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Debug, exception, format, arg0);
        }

        public static void DebugException<TException>(this ILogger logger, TException exception, string format, object arg0, object arg1) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Debug, exception, format, arg0, arg1);
        }

        public static void DebugException<TException>(this ILogger logger, TException exception, string format, object arg0, object arg1, object arg2) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Debug, exception, format, arg0, arg1, arg2);
        }

        public static void DebugException<TException>(this ILogger logger, TException exception, string format, params object[] args) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Debug, exception, format, args);
        }

        public static void DebugException<TException>(this ILogger logger, TException exception, Func<string> messageGenerator) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Debug, exception, messageGenerator);
        }

        public static void Info(this ILogger logger, string message)
        {
            logger.Log(LogEntryLevel.Info, message);
        }

        public static void Info(this ILogger logger, string format, object arg0)
        {
            logger.Log(LogEntryLevel.Info, format, arg0);
        }

        public static void Info(this ILogger logger, string format, object arg0, object arg1)
        {
            logger.Log(LogEntryLevel.Info, format, arg0, arg1);
        }

        public static void Info(this ILogger logger, string format, object arg0, object arg1, object arg2)
        {
            logger.Log(LogEntryLevel.Info, format, arg0, arg1, arg2);
        }

        public static void Info(this ILogger logger, string format, params object[] args)
        {
            logger.Log(LogEntryLevel.Info, format, args);
        }

        public static void Info(this ILogger logger, Func<string> messageGenerator)
        {
            logger.Log(LogEntryLevel.Info, messageGenerator);
        }

        public static void InfoException<TException>(this ILogger logger, TException exception) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Info, exception);
        }

        public static void InfoException<TException>(this ILogger logger, TException exception, string message) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Info, exception, message);
        }

        public static void InfoException<TException>(this ILogger logger, TException exception, string format, object arg0) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Info, exception, format, arg0);
        }

        public static void InfoException<TException>(this ILogger logger, TException exception, string format, object arg0, object arg1) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Info, exception, format, arg0, arg1);
        }

        public static void InfoException<TException>(this ILogger logger, TException exception, string format, object arg0, object arg1, object arg2) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Info, exception, format, arg0, arg1, arg2);
        }

        public static void InfoException<TException>(this ILogger logger, TException exception, string format, params object[] args) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Info, exception, format, args);
        }

        public static void InfoException<TException>(this ILogger logger, TException exception, Func<string> messageGenerator) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Info, exception, messageGenerator);
        }

        public static void Warn(this ILogger logger, string message)
        {
            logger.Log(LogEntryLevel.Warn, message);
        }

        public static void Warn(this ILogger logger, string format, object arg0)
        {
            logger.Log(LogEntryLevel.Warn, format, arg0);
        }

        public static void Warn(this ILogger logger, string format, object arg0, object arg1)
        {
            logger.Log(LogEntryLevel.Warn, format, arg0, arg1);
        }

        public static void Warn(this ILogger logger, string format, object arg0, object arg1, object arg2)
        {
            logger.Log(LogEntryLevel.Warn, format, arg0, arg1, arg2);
        }

        public static void Warn(this ILogger logger, string format, params object[] args)
        {
            logger.Log(LogEntryLevel.Warn, format, args);
        }

        public static void Warn(this ILogger logger, Func<string> messageGenerator)
        {
            logger.Log(LogEntryLevel.Warn, messageGenerator);
        }

        public static void WarnException<TException>(this ILogger logger, TException exception) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Warn, exception);
        }

        public static void WarnException<TException>(this ILogger logger, TException exception, string message) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Warn, exception, message);
        }

        public static void WarnException<TException>(this ILogger logger, TException exception, string format, object arg0) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Warn, exception, format, arg0);
        }

        public static void WarnException<TException>(this ILogger logger, TException exception, string format, object arg0, object arg1) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Warn, exception, format, arg0, arg1);
        }

        public static void WarnException<TException>(this ILogger logger, TException exception, string format, object arg0, object arg1, object arg2) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Warn, exception, format, arg0, arg1, arg2);
        }

        public static void WarnException<TException>(this ILogger logger, TException exception, string format, params object[] args) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Warn, exception, format, args);
        }

        public static void WarnException<TException>(this ILogger logger, TException exception, Func<string> messageGenerator) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Warn, exception, messageGenerator);
        }

        public static void Error(this ILogger logger, string message)
        {
            logger.Log(LogEntryLevel.Error, message);
        }

        public static void Error(this ILogger logger, string format, object arg0)
        {
            logger.Log(LogEntryLevel.Error, format, arg0);
        }

        public static void Error(this ILogger logger, string format, object arg0, object arg1)
        {
            logger.Log(LogEntryLevel.Error, format, arg0, arg1);
        }

        public static void Error(this ILogger logger, string format, object arg0, object arg1, object arg2)
        {
            logger.Log(LogEntryLevel.Error, format, arg0, arg1, arg2);
        }

        public static void Error(this ILogger logger, string format, params object[] args)
        {
            logger.Log(LogEntryLevel.Error, format, args);
        }

        public static void Error(this ILogger logger, Func<string> messageGenerator)
        {
            logger.Log(LogEntryLevel.Error, messageGenerator);
        }

        public static void ErrorException<TException>(this ILogger logger, TException exception) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Error, exception);
        }

        public static void ErrorException<TException>(this ILogger logger, TException exception, string message) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Error, exception, message);
        }

        public static void ErrorException<TException>(this ILogger logger, TException exception, string format, object arg0) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Error, exception, format, arg0);
        }

        public static void ErrorException<TException>(this ILogger logger, TException exception, string format, object arg0, object arg1) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Error, exception, format, arg0, arg1);
        }

        public static void ErrorException<TException>(this ILogger logger, TException exception, string format, object arg0, object arg1, object arg2) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Error, exception, format, arg0, arg1, arg2);
        }

        public static void ErrorException<TException>(this ILogger logger, TException exception, string format, params object[] args) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Error, exception, format, args);
        }

        public static void ErrorException<TException>(this ILogger logger, TException exception, Func<string> messageGenerator) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Error, exception, messageGenerator);
        }

        public static void Fatal(this ILogger logger, string message)
        {
            logger.Log(LogEntryLevel.Fatal, message);
        }

        public static void Fatal(this ILogger logger, string format, object arg0)
        {
            logger.Log(LogEntryLevel.Fatal, format, arg0);
        }

        public static void Fatal(this ILogger logger, string format, object arg0, object arg1)
        {
            logger.Log(LogEntryLevel.Fatal, format, arg0, arg1);
        }

        public static void Fatal(this ILogger logger, string format, object arg0, object arg1, object arg2)
        {
            logger.Log(LogEntryLevel.Fatal, format, arg0, arg1, arg2);
        }

        public static void Fatal(this ILogger logger, string format, params object[] args)
        {
            logger.Log(LogEntryLevel.Fatal, format, args);
        }

        public static void Fatal(this ILogger logger, Func<string> messageGenerator)
        {
            logger.Log(LogEntryLevel.Fatal, messageGenerator);
        }

        public static void FatalException<TException>(this ILogger logger, TException exception) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Fatal, exception);
        }

        public static void FatalException<TException>(this ILogger logger, TException exception, string message) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Fatal, exception, message);
        }

        public static void FatalException<TException>(this ILogger logger, TException exception, string format, object arg0) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Fatal, exception, format, arg0);
        }

        public static void FatalException<TException>(this ILogger logger, TException exception, string format, object arg0, object arg1) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Fatal, exception, format, arg0, arg1);
        }

        public static void FatalException<TException>(this ILogger logger, TException exception, string format, object arg0, object arg1, object arg2) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Fatal, exception, format, arg0, arg1, arg2);
        }

        public static void FatalException<TException>(this ILogger logger, TException exception, string format, params object[] args) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Fatal, exception, format, args);
        }

        public static void FatalException<TException>(this ILogger logger, TException exception, Func<string> messageGenerator) where TException : Exception
        {
            logger.LogException(LogEntryLevel.Fatal, exception, messageGenerator);
        }
    }
}
