using System;

namespace Peons.Logging
{
    public interface ILogger
    {
        void Log(LogEntryLevel level, string message);
        void Log(LogEntryLevel level, string format, object arg0);
        void Log(LogEntryLevel level, string format, object arg0, object arg1);
        void Log(LogEntryLevel level, string format, object arg0, object arg1, object arg2);
        void Log(LogEntryLevel level, string format, params object[] args);
        void Log(LogEntryLevel level, Func<string> messageGenerator);
        void LogException<TException>(LogEntryLevel level, TException exception) where TException : Exception;
        void LogException<TException>(LogEntryLevel level, TException exception, string message) where TException : Exception;
        void LogException<TException>(LogEntryLevel level, TException exception, string format, object arg0) where TException : Exception;
        void LogException<TException>(LogEntryLevel level, TException exception, string format, object arg0, object arg1) where TException : Exception;
        void LogException<TException>(LogEntryLevel level, TException exception, string format, object arg0, object arg1, object arg2) where TException : Exception;
        void LogException<TException>(LogEntryLevel level, TException exception, string format, params object[] args) where TException : Exception;
        void LogException<TException>(LogEntryLevel level, TException exception, Func<string> messageGenerator) where TException : Exception;
    }

    public interface ILogger<T> : ILogger { }
}
