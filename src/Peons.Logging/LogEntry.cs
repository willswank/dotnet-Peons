using System;

using MESSAGE_GENERATOR = System.Func<string>;

namespace Peons.Logging
{
    /// <summary>
    /// Encapsulates a single log entry.
    /// </summary>
    public class LogEntry
    {
        private readonly LogEntryLevel _level;
        private readonly string _message;
        private readonly MESSAGE_GENERATOR _messageGenerator;
        private readonly string _source;
        private readonly Exception _exception;
        
        /// <summary>
        /// Initializes a new log entry
        /// </summary>
        /// <param name="level"></param>
        /// <param name="message"></param>
        /// <param name="source"></param>
        /// <param name="exception"></param>
        public LogEntry(LogEntryLevel level, string message, string source, Exception exception)
        {
            _exception = exception;
            _source = source;
            _message = message;
            _level = level;
        }

        /// <summary>
        /// Initializes a new log entry
        /// </summary>
        /// <param name="level"></param>
        /// <param name="message"></param>
        public LogEntry(LogEntryLevel level, string message)
        {
            _message = message;
            _level = level;
        }

        /// <summary>
        /// Initializes a new log entry
        /// </summary>
        /// <param name="level"></param>
        /// <param name="exception"></param>
        public LogEntry(LogEntryLevel level, Exception exception)
        {
            _exception = exception;
            _level = level;
        }

        /// <summary>
        /// Initializes a new log entry
        /// </summary>
        /// <param name="level"></param>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public LogEntry(LogEntryLevel level, string message, Exception exception)
        {
            _message = message;
            _exception = exception;
            _level = level;
        }

        /// <summary>
        /// Initializes a new log entry
        /// </summary>
        /// <param name="level"></param>
        /// <param name="messageGenerator"></param>
        /// <param name="source"></param>
        /// <param name="exception"></param>
        public LogEntry(LogEntryLevel level, MESSAGE_GENERATOR messageGenerator, string source, Exception exception)
        {
            _exception = exception;
            _source = source;
            _messageGenerator = messageGenerator;
            _level = level;
        }

        /// <summary>
        /// Initializes a new log entry
        /// </summary>
        /// <param name="level"></param>
        /// <param name="messageGenerator"></param>
        public LogEntry(LogEntryLevel level, MESSAGE_GENERATOR messageGenerator)
        {
            _messageGenerator = messageGenerator;
            _level = level;
        }

        /// <summary>
        /// Initializes a new log entry
        /// </summary>
        /// <param name="level"></param>
        /// <param name="messageGenerator"></param>
        /// <param name="exception"></param>
        public LogEntry(LogEntryLevel level, MESSAGE_GENERATOR messageGenerator, Exception exception)
        {
            _messageGenerator = messageGenerator;
            _exception = exception;
            _level = level;
        }

        /// <summary>
        /// The level of logged event. Debug, Info, Error, etc.
        /// </summary>
        public LogEntryLevel Level
        {
            get
            {
                return _level;
            }
        }

        /// <summary>
        /// The log message
        /// </summary>
        public string Message
        {
            get
            {
                return _message;
            }
        }

        /// <summary>
        /// The message generator
        /// </summary>
        public MESSAGE_GENERATOR MessageGenerator
        {
            get
            {
                return _messageGenerator;
            }
        }

        /// <summary>
        /// The source of the log entry
        /// </summary>
        public string Source
        {
            get
            {
                return _source;
            }
        }

        /// <summary>
        /// Exception object.
        /// </summary>
        public Exception Exception
        {
            get
            {
                return _exception;
            }
        }

        public override string ToString()
        {
            return _message;                
        }
    }
}
