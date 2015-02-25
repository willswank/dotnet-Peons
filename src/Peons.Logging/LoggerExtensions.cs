using System;

namespace Peons.Logging
{
    public static class LoggerExtensions
    {
        public static void Trace(this ILogger logger, string message)
        {
            logger.Log(LogLevel.Trace, message);
        }

        public static void Trace(this ILogger logger, string format, object arg0)
        {
            logger.Log(LogLevel.Trace, format, arg0);
        }

        public static void Trace(this ILogger logger, string format, object arg0, object arg1)
        {
            logger.Log(LogLevel.Trace, format, arg0, arg1);
        }

        public static void Trace(this ILogger logger, string format, object arg0, object arg1, object arg2)
        {
            logger.Log(LogLevel.Trace, format, arg0, arg1, arg2);
        }

        public static void Trace(this ILogger logger, string format, params object[] args)
        {
            logger.Log(LogLevel.Trace, format, args);
        }

        public static void Trace(this ILogger logger, Func<string> messageGenerator)
        {
            logger.Log(LogLevel.Trace, messageGenerator);
        }

        public static void TraceException<TException>(this ILogger logger, TException exception) where TException : Exception
        {
            logger.LogException(LogLevel.Trace, exception);
        }

        public static void TraceException<TException>(this ILogger logger, TException exception, string message) where TException : Exception
        {
            logger.LogException(LogLevel.Trace, exception, message);
        }

        public static void TraceException<TException>(this ILogger logger, TException exception, string format, object arg0) where TException : Exception
        {
            logger.LogException(LogLevel.Trace, exception, format, arg0);
        }

        public static void TraceException<TException>(this ILogger logger, TException exception, string format, object arg0, object arg1) where TException : Exception
        {
            logger.LogException(LogLevel.Trace, exception, format, arg0, arg1);
        }

        public static void TraceException<TException>(this ILogger logger, TException exception, string format, object arg0, object arg1, object arg2) where TException : Exception
        {
            logger.LogException(LogLevel.Trace, exception, format, arg0, arg1, arg2);
        }

        public static void TraceException<TException>(this ILogger logger, TException exception, string format, params object[] args) where TException : Exception
        {
            logger.LogException(LogLevel.Trace, exception, format, args);
        }

        public static void TraceException<TException>(this ILogger logger, TException exception, Func<string> messageGenerator) where TException : Exception
        {
            logger.LogException(LogLevel.Trace, exception, messageGenerator);
        }

        public static void Debug(this ILogger logger, string message)
        {
            logger.Log(LogLevel.Debug, message);
        }

        public static void Debug(this ILogger logger, string format, object arg0)
        {
            logger.Log(LogLevel.Debug, format, arg0);
        }

        public static void Debug(this ILogger logger, string format, object arg0, object arg1)
        {
            logger.Log(LogLevel.Debug, format, arg0, arg1);
        }

        public static void Debug(this ILogger logger, string format, object arg0, object arg1, object arg2)
        {
            logger.Log(LogLevel.Debug, format, arg0, arg1, arg2);
        }

        public static void Debug(this ILogger logger, string format, params object[] args)
        {
            logger.Log(LogLevel.Debug, format, args);
        }

        public static void Debug(this ILogger logger, Func<string> messageGenerator)
        {
            logger.Log(LogLevel.Debug, messageGenerator);
        }

        public static void DebugException<TException>(this ILogger logger, TException exception) where TException : Exception
        {
            logger.LogException(LogLevel.Debug, exception);
        }

        public static void DebugException<TException>(this ILogger logger, TException exception, string message) where TException : Exception
        {
            logger.LogException(LogLevel.Debug, exception, message);
        }

        public static void DebugException<TException>(this ILogger logger, TException exception, string format, object arg0) where TException : Exception
        {
            logger.LogException(LogLevel.Debug, exception, format, arg0);
        }

        public static void DebugException<TException>(this ILogger logger, TException exception, string format, object arg0, object arg1) where TException : Exception
        {
            logger.LogException(LogLevel.Debug, exception, format, arg0, arg1);
        }

        public static void DebugException<TException>(this ILogger logger, TException exception, string format, object arg0, object arg1, object arg2) where TException : Exception
        {
            logger.LogException(LogLevel.Debug, exception, format, arg0, arg1, arg2);
        }

        public static void DebugException<TException>(this ILogger logger, TException exception, string format, params object[] args) where TException : Exception
        {
            logger.LogException(LogLevel.Debug, exception, format, args);
        }

        public static void DebugException<TException>(this ILogger logger, TException exception, Func<string> messageGenerator) where TException : Exception
        {
            logger.LogException(LogLevel.Debug, exception, messageGenerator);
        }

        public static void Info(this ILogger logger, string message)
        {
            logger.Log(LogLevel.Info, message);
        }

        public static void Info(this ILogger logger, string format, object arg0)
        {
            logger.Log(LogLevel.Info, format, arg0);
        }

        public static void Info(this ILogger logger, string format, object arg0, object arg1)
        {
            logger.Log(LogLevel.Info, format, arg0, arg1);
        }

        public static void Info(this ILogger logger, string format, object arg0, object arg1, object arg2)
        {
            logger.Log(LogLevel.Info, format, arg0, arg1, arg2);
        }

        public static void Info(this ILogger logger, string format, params object[] args)
        {
            logger.Log(LogLevel.Info, format, args);
        }

        public static void Info(this ILogger logger, Func<string> messageGenerator)
        {
            logger.Log(LogLevel.Info, messageGenerator);
        }

        public static void InfoException<TException>(this ILogger logger, TException exception) where TException : Exception
        {
            logger.LogException(LogLevel.Info, exception);
        }

        public static void InfoException<TException>(this ILogger logger, TException exception, string message) where TException : Exception
        {
            logger.LogException(LogLevel.Info, exception, message);
        }

        public static void InfoException<TException>(this ILogger logger, TException exception, string format, object arg0) where TException : Exception
        {
            logger.LogException(LogLevel.Info, exception, format, arg0);
        }

        public static void InfoException<TException>(this ILogger logger, TException exception, string format, object arg0, object arg1) where TException : Exception
        {
            logger.LogException(LogLevel.Info, exception, format, arg0, arg1);
        }

        public static void InfoException<TException>(this ILogger logger, TException exception, string format, object arg0, object arg1, object arg2) where TException : Exception
        {
            logger.LogException(LogLevel.Info, exception, format, arg0, arg1, arg2);
        }

        public static void InfoException<TException>(this ILogger logger, TException exception, string format, params object[] args) where TException : Exception
        {
            logger.LogException(LogLevel.Info, exception, format, args);
        }

        public static void InfoException<TException>(this ILogger logger, TException exception, Func<string> messageGenerator) where TException : Exception
        {
            logger.LogException(LogLevel.Info, exception, messageGenerator);
        }

        public static void Warn(this ILogger logger, string message)
        {
            logger.Log(LogLevel.Warn, message);
        }

        public static void Warn(this ILogger logger, string format, object arg0)
        {
            logger.Log(LogLevel.Warn, format, arg0);
        }

        public static void Warn(this ILogger logger, string format, object arg0, object arg1)
        {
            logger.Log(LogLevel.Warn, format, arg0, arg1);
        }

        public static void Warn(this ILogger logger, string format, object arg0, object arg1, object arg2)
        {
            logger.Log(LogLevel.Warn, format, arg0, arg1, arg2);
        }

        public static void Warn(this ILogger logger, string format, params object[] args)
        {
            logger.Log(LogLevel.Warn, format, args);
        }

        public static void Warn(this ILogger logger, Func<string> messageGenerator)
        {
            logger.Log(LogLevel.Warn, messageGenerator);
        }

        public static void WarnException<TException>(this ILogger logger, TException exception) where TException : Exception
        {
            logger.LogException(LogLevel.Warn, exception);
        }

        public static void WarnException<TException>(this ILogger logger, TException exception, string message) where TException : Exception
        {
            logger.LogException(LogLevel.Warn, exception, message);
        }

        public static void WarnException<TException>(this ILogger logger, TException exception, string format, object arg0) where TException : Exception
        {
            logger.LogException(LogLevel.Warn, exception, format, arg0);
        }

        public static void WarnException<TException>(this ILogger logger, TException exception, string format, object arg0, object arg1) where TException : Exception
        {
            logger.LogException(LogLevel.Warn, exception, format, arg0, arg1);
        }

        public static void WarnException<TException>(this ILogger logger, TException exception, string format, object arg0, object arg1, object arg2) where TException : Exception
        {
            logger.LogException(LogLevel.Warn, exception, format, arg0, arg1, arg2);
        }

        public static void WarnException<TException>(this ILogger logger, TException exception, string format, params object[] args) where TException : Exception
        {
            logger.LogException(LogLevel.Warn, exception, format, args);
        }

        public static void WarnException<TException>(this ILogger logger, TException exception, Func<string> messageGenerator) where TException : Exception
        {
            logger.LogException(LogLevel.Warn, exception, messageGenerator);
        }

        public static void Error(this ILogger logger, string message)
        {
            logger.Log(LogLevel.Error, message);
        }

        public static void Error(this ILogger logger, string format, object arg0)
        {
            logger.Log(LogLevel.Error, format, arg0);
        }

        public static void Error(this ILogger logger, string format, object arg0, object arg1)
        {
            logger.Log(LogLevel.Error, format, arg0, arg1);
        }

        public static void Error(this ILogger logger, string format, object arg0, object arg1, object arg2)
        {
            logger.Log(LogLevel.Error, format, arg0, arg1, arg2);
        }

        public static void Error(this ILogger logger, string format, params object[] args)
        {
            logger.Log(LogLevel.Error, format, args);
        }

        public static void Error(this ILogger logger, Func<string> messageGenerator)
        {
            logger.Log(LogLevel.Error, messageGenerator);
        }

        public static void ErrorException<TException>(this ILogger logger, TException exception) where TException : Exception
        {
            logger.LogException(LogLevel.Error, exception);
        }

        public static void ErrorException<TException>(this ILogger logger, TException exception, string message) where TException : Exception
        {
            logger.LogException(LogLevel.Error, exception, message);
        }

        public static void ErrorException<TException>(this ILogger logger, TException exception, string format, object arg0) where TException : Exception
        {
            logger.LogException(LogLevel.Error, exception, format, arg0);
        }

        public static void ErrorException<TException>(this ILogger logger, TException exception, string format, object arg0, object arg1) where TException : Exception
        {
            logger.LogException(LogLevel.Error, exception, format, arg0, arg1);
        }

        public static void ErrorException<TException>(this ILogger logger, TException exception, string format, object arg0, object arg1, object arg2) where TException : Exception
        {
            logger.LogException(LogLevel.Error, exception, format, arg0, arg1, arg2);
        }

        public static void ErrorException<TException>(this ILogger logger, TException exception, string format, params object[] args) where TException : Exception
        {
            logger.LogException(LogLevel.Error, exception, format, args);
        }

        public static void ErrorException<TException>(this ILogger logger, TException exception, Func<string> messageGenerator) where TException : Exception
        {
            logger.LogException(LogLevel.Error, exception, messageGenerator);
        }

        public static void Fatal(this ILogger logger, string message)
        {
            logger.Log(LogLevel.Fatal, message);
        }

        public static void Fatal(this ILogger logger, string format, object arg0)
        {
            logger.Log(LogLevel.Fatal, format, arg0);
        }

        public static void Fatal(this ILogger logger, string format, object arg0, object arg1)
        {
            logger.Log(LogLevel.Fatal, format, arg0, arg1);
        }

        public static void Fatal(this ILogger logger, string format, object arg0, object arg1, object arg2)
        {
            logger.Log(LogLevel.Fatal, format, arg0, arg1, arg2);
        }

        public static void Fatal(this ILogger logger, string format, params object[] args)
        {
            logger.Log(LogLevel.Fatal, format, args);
        }

        public static void Fatal(this ILogger logger, Func<string> messageGenerator)
        {
            logger.Log(LogLevel.Fatal, messageGenerator);
        }

        public static void FatalException<TException>(this ILogger logger, TException exception) where TException : Exception
        {
            logger.LogException(LogLevel.Fatal, exception);
        }

        public static void FatalException<TException>(this ILogger logger, TException exception, string message) where TException : Exception
        {
            logger.LogException(LogLevel.Fatal, exception, message);
        }

        public static void FatalException<TException>(this ILogger logger, TException exception, string format, object arg0) where TException : Exception
        {
            logger.LogException(LogLevel.Fatal, exception, format, arg0);
        }

        public static void FatalException<TException>(this ILogger logger, TException exception, string format, object arg0, object arg1) where TException : Exception
        {
            logger.LogException(LogLevel.Fatal, exception, format, arg0, arg1);
        }

        public static void FatalException<TException>(this ILogger logger, TException exception, string format, object arg0, object arg1, object arg2) where TException : Exception
        {
            logger.LogException(LogLevel.Fatal, exception, format, arg0, arg1, arg2);
        }

        public static void FatalException<TException>(this ILogger logger, TException exception, string format, params object[] args) where TException : Exception
        {
            logger.LogException(LogLevel.Fatal, exception, format, args);
        }

        public static void FatalException<TException>(this ILogger logger, TException exception, Func<string> messageGenerator) where TException : Exception
        {
            logger.LogException(LogLevel.Fatal, exception, messageGenerator);
        }
    }
}
