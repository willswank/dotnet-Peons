using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peons.Logging
{
    public enum LogEventType
    {
        /// <summary>
        /// Log level to provide trace level information. Typically used during development.
        /// Contains verbose output.
        /// </summary>
        Trace = 0,

        /// <summary>
        /// Log level used for debugging.
        /// </summary>
        Debug = 1,

        /// <summary>
        /// Log level used for information purposes.
        /// </summary>
        Info = 2,

        /// <summary>
        /// Log level for errors.
        /// </summary>
        Error = 3,

        /// <summary>
        /// Log level for severe errors...usually un-recoverable.
        /// </summary>
        Fatal = 4
    }
}
