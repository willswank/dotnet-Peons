using Moq;
using NUnit.Framework;
using System;

using UNIT = Peons.Logging.LoggerExtensions;

namespace Peons.Logging
{
    [TestFixture]
    public class LoggerExtensionsTests
    {
        const string MESSAGE = "foo";
        const string ARG0 = "bar";
        const string ARG1 = "beer";
        const string ARG2 = "gin";
        const string ARG3 = "tequila";
        static readonly Exception EXCEPTION = new Exception();
        static readonly Func<string> GENERATOR = new Func<string>(() => "foobar");

        Mock<ILogger> loggerMock;
        ILogger logger;

        [SetUp]
        protected void Setup()
        {
            loggerMock = new Mock<ILogger>();
            logger = loggerMock.Object;
        }

        [Test]
        public void Trace_Message_LogsEntry()
        {
            UNIT.Trace(logger, MESSAGE);
            loggerMock
                .Verify(m => m.Log(LogLevel.Trace, MESSAGE), Times.Once);
        }

        [Test]
        public void Trace_FormatAndArg_LogsEntry()
        {
            UNIT.Trace(logger, MESSAGE, ARG0);
            loggerMock
                .Verify(m => m.Log(LogLevel.Trace, MESSAGE, ARG0), Times.Once);
        }

        [Test]
        public void Trace_FormatAnd2Args_LogsEntry()
        {
            UNIT.Trace(logger, MESSAGE, ARG0, ARG1);
            loggerMock
                .Verify(m => m.Log(LogLevel.Trace, MESSAGE, ARG0, ARG1), Times.Once);
        }

        [Test]
        public void Trace_FormatAnd3Args_LogsEntry()
        {
            UNIT.Trace(logger, MESSAGE, ARG0, ARG1, ARG2);
            loggerMock
                .Verify(m => m.Log(LogLevel.Trace, MESSAGE, ARG0, ARG1, ARG2), Times.Once);
        }

        [Test]
        public void Trace_FormatAnd4Args_LogsEntry()
        {
            UNIT.Trace(logger, MESSAGE, ARG0, ARG1, ARG2, ARG3);
            loggerMock
                .Verify(m => m.Log(LogLevel.Trace, MESSAGE, ARG0, ARG1, ARG2, ARG3), Times.Once);
        }

        [Test]
        public void Trace_MessageGenerator_LogsEntry()
        {
            UNIT.Trace(logger, GENERATOR);
            loggerMock
                .Verify(m => m.Log(LogLevel.Trace, GENERATOR), Times.Once);
        }

        [Test]
        public void TraceException_Exception_LogsEntry()
        {
            UNIT.TraceException(logger, EXCEPTION);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Trace, EXCEPTION), Times.Once);
        }

        [Test]
        public void TraceException_ExceptionAndMessage_LogsEntry()
        {
            UNIT.TraceException(logger, EXCEPTION, MESSAGE);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Trace, EXCEPTION, MESSAGE), Times.Once);
        }

        [Test]
        public void TraceException_ExceptionAndFormatAndArg_LogsEntry()
        {
            UNIT.TraceException(logger, EXCEPTION, MESSAGE, ARG0);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Trace, EXCEPTION, MESSAGE, ARG0), Times.Once);
        }

        [Test]
        public void TraceException_ExceptionAndFormatAnd2Args_LogsEntry()
        {
            UNIT.TraceException(logger, EXCEPTION, MESSAGE, ARG0, ARG1);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Trace, EXCEPTION, MESSAGE, ARG0, ARG1), Times.Once);
        }

        [Test]
        public void TraceException_ExceptionAndFormatAnd3Args_LogsEntry()
        {
            UNIT.TraceException(logger, EXCEPTION, MESSAGE, ARG0, ARG1, ARG2);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Trace, EXCEPTION, MESSAGE, ARG0, ARG1, ARG2), Times.Once);
        }

        [Test]
        public void TraceException_ExceptionAndFormatAnd4Args_LogsEntry()
        {
            UNIT.TraceException(logger, EXCEPTION, MESSAGE, ARG0, ARG1, ARG2, ARG3);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Trace, EXCEPTION, MESSAGE, ARG0, ARG1, ARG2, ARG3), Times.Once);
        }

        [Test]
        public void TraceException_ExceptionAndMessageGenerator_LogsEntry()
        {
            UNIT.TraceException(logger, EXCEPTION, GENERATOR);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Trace, EXCEPTION, GENERATOR), Times.Once);
        }

        [Test]
        public void Debug_Message_LogsEntry()
        {
            UNIT.Debug(logger, MESSAGE);
            loggerMock
                .Verify(m => m.Log(LogLevel.Debug, MESSAGE), Times.Once);
        }

        [Test]
        public void Debug_FormatAndArg_LogsEntry()
        {
            UNIT.Debug(logger, MESSAGE, ARG0);
            loggerMock
                .Verify(m => m.Log(LogLevel.Debug, MESSAGE, ARG0), Times.Once);
        }

        [Test]
        public void Debug_FormatAnd2Args_LogsEntry()
        {
            UNIT.Debug(logger, MESSAGE, ARG0, ARG1);
            loggerMock
                .Verify(m => m.Log(LogLevel.Debug, MESSAGE, ARG0, ARG1), Times.Once);
        }

        [Test]
        public void Debug_FormatAnd3Args_LogsEntry()
        {
            UNIT.Debug(logger, MESSAGE, ARG0, ARG1, ARG2);
            loggerMock
                .Verify(m => m.Log(LogLevel.Debug, MESSAGE, ARG0, ARG1, ARG2), Times.Once);
        }

        [Test]
        public void Debug_FormatAnd4Args_LogsEntry()
        {
            UNIT.Debug(logger, MESSAGE, ARG0, ARG1, ARG2, ARG3);
            loggerMock
                .Verify(m => m.Log(LogLevel.Debug, MESSAGE, ARG0, ARG1, ARG2, ARG3), Times.Once);
        }

        [Test]
        public void Debug_MessageGenerator_LogsEntry()
        {
            UNIT.Debug(logger, GENERATOR);
            loggerMock
                .Verify(m => m.Log(LogLevel.Debug, GENERATOR), Times.Once);
        }

        [Test]
        public void DebugException_Exception_LogsEntry()
        {
            UNIT.DebugException(logger, EXCEPTION);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Debug, EXCEPTION), Times.Once);
        }

        [Test]
        public void DebugException_ExceptionAndMessage_LogsEntry()
        {
            UNIT.DebugException(logger, EXCEPTION, MESSAGE);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Debug, EXCEPTION, MESSAGE), Times.Once);
        }

        [Test]
        public void DebugException_ExceptionAndFormatAndArg_LogsEntry()
        {
            UNIT.DebugException(logger, EXCEPTION, MESSAGE, ARG0);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Debug, EXCEPTION, MESSAGE, ARG0), Times.Once);
        }

        [Test]
        public void DebugException_ExceptionAndFormatAnd2Args_LogsEntry()
        {
            UNIT.DebugException(logger, EXCEPTION, MESSAGE, ARG0, ARG1);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Debug, EXCEPTION, MESSAGE, ARG0, ARG1), Times.Once);
        }

        [Test]
        public void DebugException_ExceptionAndFormatAnd3Args_LogsEntry()
        {
            UNIT.DebugException(logger, EXCEPTION, MESSAGE, ARG0, ARG1, ARG2);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Debug, EXCEPTION, MESSAGE, ARG0, ARG1, ARG2), Times.Once);
        }

        [Test]
        public void DebugException_ExceptionAndFormatAnd4Args_LogsEntry()
        {
            UNIT.DebugException(logger, EXCEPTION, MESSAGE, ARG0, ARG1, ARG2, ARG3);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Debug, EXCEPTION, MESSAGE, ARG0, ARG1, ARG2, ARG3), Times.Once);
        }

        [Test]
        public void DebugException_ExceptionAndMessageGenerator_LogsEntry()
        {
            UNIT.DebugException(logger, EXCEPTION, GENERATOR);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Debug, EXCEPTION, GENERATOR), Times.Once);
        }

        [Test]
        public void Info_Message_LogsEntry()
        {
            UNIT.Info(logger, MESSAGE);
            loggerMock
                .Verify(m => m.Log(LogLevel.Info, MESSAGE), Times.Once);
        }

        [Test]
        public void Info_FormatAndArg_LogsEntry()
        {
            UNIT.Info(logger, MESSAGE, ARG0);
            loggerMock
                .Verify(m => m.Log(LogLevel.Info, MESSAGE, ARG0), Times.Once);
        }

        [Test]
        public void Info_FormatAnd2Args_LogsEntry()
        {
            UNIT.Info(logger, MESSAGE, ARG0, ARG1);
            loggerMock
                .Verify(m => m.Log(LogLevel.Info, MESSAGE, ARG0, ARG1), Times.Once);
        }

        [Test]
        public void Info_FormatAnd3Args_LogsEntry()
        {
            UNIT.Info(logger, MESSAGE, ARG0, ARG1, ARG2);
            loggerMock
                .Verify(m => m.Log(LogLevel.Info, MESSAGE, ARG0, ARG1, ARG2), Times.Once);
        }

        [Test]
        public void Info_FormatAnd4Args_LogsEntry()
        {
            UNIT.Info(logger, MESSAGE, ARG0, ARG1, ARG2, ARG3);
            loggerMock
                .Verify(m => m.Log(LogLevel.Info, MESSAGE, ARG0, ARG1, ARG2, ARG3), Times.Once);
        }

        [Test]
        public void Info_MessageGenerator_LogsEntry()
        {
            UNIT.Info(logger, GENERATOR);
            loggerMock
                .Verify(m => m.Log(LogLevel.Info, GENERATOR), Times.Once);
        }

        [Test]
        public void InfoException_Exception_LogsEntry()
        {
            UNIT.InfoException(logger, EXCEPTION);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Info, EXCEPTION), Times.Once);
        }

        [Test]
        public void InfoException_ExceptionAndMessage_LogsEntry()
        {
            UNIT.InfoException(logger, EXCEPTION, MESSAGE);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Info, EXCEPTION, MESSAGE), Times.Once);
        }

        [Test]
        public void InfoException_ExceptionAndFormatAndArg_LogsEntry()
        {
            UNIT.InfoException(logger, EXCEPTION, MESSAGE, ARG0);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Info, EXCEPTION, MESSAGE, ARG0), Times.Once);
        }

        [Test]
        public void InfoException_ExceptionAndFormatAnd2Args_LogsEntry()
        {
            UNIT.InfoException(logger, EXCEPTION, MESSAGE, ARG0, ARG1);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Info, EXCEPTION, MESSAGE, ARG0, ARG1), Times.Once);
        }

        [Test]
        public void InfoException_ExceptionAndFormatAnd3Args_LogsEntry()
        {
            UNIT.InfoException(logger, EXCEPTION, MESSAGE, ARG0, ARG1, ARG2);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Info, EXCEPTION, MESSAGE, ARG0, ARG1, ARG2), Times.Once);
        }

        [Test]
        public void InfoException_ExceptionAndFormatAnd4Args_LogsEntry()
        {
            UNIT.InfoException(logger, EXCEPTION, MESSAGE, ARG0, ARG1, ARG2, ARG3);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Info, EXCEPTION, MESSAGE, ARG0, ARG1, ARG2, ARG3), Times.Once);
        }

        [Test]
        public void InfoException_ExceptionAndMessageGenerator_LogsEntry()
        {
            UNIT.InfoException(logger, EXCEPTION, GENERATOR);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Info, EXCEPTION, GENERATOR), Times.Once);
        }

        [Test]
        public void Warn_Message_LogsEntry()
        {
            UNIT.Warn(logger, MESSAGE);
            loggerMock
                .Verify(m => m.Log(LogLevel.Warn, MESSAGE), Times.Once);
        }

        [Test]
        public void Warn_FormatAndArg_LogsEntry()
        {
            UNIT.Warn(logger, MESSAGE, ARG0);
            loggerMock
                .Verify(m => m.Log(LogLevel.Warn, MESSAGE, ARG0), Times.Once);
        }

        [Test]
        public void Warn_FormatAnd2Args_LogsEntry()
        {
            UNIT.Warn(logger, MESSAGE, ARG0, ARG1);
            loggerMock
                .Verify(m => m.Log(LogLevel.Warn, MESSAGE, ARG0, ARG1), Times.Once);
        }

        [Test]
        public void Warn_FormatAnd3Args_LogsEntry()
        {
            UNIT.Warn(logger, MESSAGE, ARG0, ARG1, ARG2);
            loggerMock
                .Verify(m => m.Log(LogLevel.Warn, MESSAGE, ARG0, ARG1, ARG2), Times.Once);
        }

        [Test]
        public void Warn_FormatAnd4Args_LogsEntry()
        {
            UNIT.Warn(logger, MESSAGE, ARG0, ARG1, ARG2, ARG3);
            loggerMock
                .Verify(m => m.Log(LogLevel.Warn, MESSAGE, ARG0, ARG1, ARG2, ARG3), Times.Once);
        }

        [Test]
        public void Warn_MessageGenerator_LogsEntry()
        {
            UNIT.Warn(logger, GENERATOR);
            loggerMock
                .Verify(m => m.Log(LogLevel.Warn, GENERATOR), Times.Once);
        }

        [Test]
        public void WarnException_Exception_LogsEntry()
        {
            UNIT.WarnException(logger, EXCEPTION);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Warn, EXCEPTION), Times.Once);
        }

        [Test]
        public void WarnException_ExceptionAndMessage_LogsEntry()
        {
            UNIT.WarnException(logger, EXCEPTION, MESSAGE);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Warn, EXCEPTION, MESSAGE), Times.Once);
        }

        [Test]
        public void WarnException_ExceptionAndFormatAndArg_LogsEntry()
        {
            UNIT.WarnException(logger, EXCEPTION, MESSAGE, ARG0);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Warn, EXCEPTION, MESSAGE, ARG0), Times.Once);
        }

        [Test]
        public void WarnException_ExceptionAndFormatAnd2Args_LogsEntry()
        {
            UNIT.WarnException(logger, EXCEPTION, MESSAGE, ARG0, ARG1);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Warn, EXCEPTION, MESSAGE, ARG0, ARG1), Times.Once);
        }

        [Test]
        public void WarnException_ExceptionAndFormatAnd3Args_LogsEntry()
        {
            UNIT.WarnException(logger, EXCEPTION, MESSAGE, ARG0, ARG1, ARG2);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Warn, EXCEPTION, MESSAGE, ARG0, ARG1, ARG2), Times.Once);
        }

        [Test]
        public void WarnException_ExceptionAndFormatAnd4Args_LogsEntry()
        {
            UNIT.WarnException(logger, EXCEPTION, MESSAGE, ARG0, ARG1, ARG2, ARG3);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Warn, EXCEPTION, MESSAGE, ARG0, ARG1, ARG2, ARG3), Times.Once);
        }

        [Test]
        public void WarnException_ExceptionAndMessageGenerator_LogsEntry()
        {
            UNIT.WarnException(logger, EXCEPTION, GENERATOR);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Warn, EXCEPTION, GENERATOR), Times.Once);
        }

        [Test]
        public void Error_Message_LogsEntry()
        {
            UNIT.Error(logger, MESSAGE);
            loggerMock
                .Verify(m => m.Log(LogLevel.Error, MESSAGE), Times.Once);
        }

        [Test]
        public void Error_FormatAndArg_LogsEntry()
        {
            UNIT.Error(logger, MESSAGE, ARG0);
            loggerMock
                .Verify(m => m.Log(LogLevel.Error, MESSAGE, ARG0), Times.Once);
        }

        [Test]
        public void Error_FormatAnd2Args_LogsEntry()
        {
            UNIT.Error(logger, MESSAGE, ARG0, ARG1);
            loggerMock
                .Verify(m => m.Log(LogLevel.Error, MESSAGE, ARG0, ARG1), Times.Once);
        }

        [Test]
        public void Error_FormatAnd3Args_LogsEntry()
        {
            UNIT.Error(logger, MESSAGE, ARG0, ARG1, ARG2);
            loggerMock
                .Verify(m => m.Log(LogLevel.Error, MESSAGE, ARG0, ARG1, ARG2), Times.Once);
        }

        [Test]
        public void Error_FormatAnd4Args_LogsEntry()
        {
            UNIT.Error(logger, MESSAGE, ARG0, ARG1, ARG2, ARG3);
            loggerMock
                .Verify(m => m.Log(LogLevel.Error, MESSAGE, ARG0, ARG1, ARG2, ARG3), Times.Once);
        }

        [Test]
        public void Error_MessageGenerator_LogsEntry()
        {
            UNIT.Error(logger, GENERATOR);
            loggerMock
                .Verify(m => m.Log(LogLevel.Error, GENERATOR), Times.Once);
        }

        [Test]
        public void ErrorException_Exception_LogsEntry()
        {
            UNIT.ErrorException(logger, EXCEPTION);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Error, EXCEPTION), Times.Once);
        }

        [Test]
        public void ErrorException_ExceptionAndMessage_LogsEntry()
        {
            UNIT.ErrorException(logger, EXCEPTION, MESSAGE);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Error, EXCEPTION, MESSAGE), Times.Once);
        }

        [Test]
        public void ErrorException_ExceptionAndFormatAndArg_LogsEntry()
        {
            UNIT.ErrorException(logger, EXCEPTION, MESSAGE, ARG0);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Error, EXCEPTION, MESSAGE, ARG0), Times.Once);
        }

        [Test]
        public void ErrorException_ExceptionAndFormatAnd2Args_LogsEntry()
        {
            UNIT.ErrorException(logger, EXCEPTION, MESSAGE, ARG0, ARG1);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Error, EXCEPTION, MESSAGE, ARG0, ARG1), Times.Once);
        }

        [Test]
        public void ErrorException_ExceptionAndFormatAnd3Args_LogsEntry()
        {
            UNIT.ErrorException(logger, EXCEPTION, MESSAGE, ARG0, ARG1, ARG2);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Error, EXCEPTION, MESSAGE, ARG0, ARG1, ARG2), Times.Once);
        }

        [Test]
        public void ErrorException_ExceptionAndFormatAnd4Args_LogsEntry()
        {
            UNIT.ErrorException(logger, EXCEPTION, MESSAGE, ARG0, ARG1, ARG2, ARG3);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Error, EXCEPTION, MESSAGE, ARG0, ARG1, ARG2, ARG3), Times.Once);
        }

        [Test]
        public void ErrorException_ExceptionAndMessageGenerator_LogsEntry()
        {
            UNIT.ErrorException(logger, EXCEPTION, GENERATOR);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Error, EXCEPTION, GENERATOR), Times.Once);
        }

        [Test]
        public void Fatal_Message_LogsEntry()
        {
            UNIT.Fatal(logger, MESSAGE);
            loggerMock
                .Verify(m => m.Log(LogLevel.Fatal, MESSAGE), Times.Once);
        }

        [Test]
        public void Fatal_FormatAndArg_LogsEntry()
        {
            UNIT.Fatal(logger, MESSAGE, ARG0);
            loggerMock
                .Verify(m => m.Log(LogLevel.Fatal, MESSAGE, ARG0), Times.Once);
        }

        [Test]
        public void Fatal_FormatAnd2Args_LogsEntry()
        {
            UNIT.Fatal(logger, MESSAGE, ARG0, ARG1);
            loggerMock
                .Verify(m => m.Log(LogLevel.Fatal, MESSAGE, ARG0, ARG1), Times.Once);
        }

        [Test]
        public void Fatal_FormatAnd3Args_LogsEntry()
        {
            UNIT.Fatal(logger, MESSAGE, ARG0, ARG1, ARG2);
            loggerMock
                .Verify(m => m.Log(LogLevel.Fatal, MESSAGE, ARG0, ARG1, ARG2), Times.Once);
        }

        [Test]
        public void Fatal_FormatAnd4Args_LogsEntry()
        {
            UNIT.Fatal(logger, MESSAGE, ARG0, ARG1, ARG2, ARG3);
            loggerMock
                .Verify(m => m.Log(LogLevel.Fatal, MESSAGE, ARG0, ARG1, ARG2, ARG3), Times.Once);
        }

        [Test]
        public void Fatal_MessageGenerator_LogsEntry()
        {
            UNIT.Fatal(logger, GENERATOR);
            loggerMock
                .Verify(m => m.Log(LogLevel.Fatal, GENERATOR), Times.Once);
        }

        [Test]
        public void FatalException_Exception_LogsEntry()
        {
            UNIT.FatalException(logger, EXCEPTION);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Fatal, EXCEPTION), Times.Once);
        }

        [Test]
        public void FatalException_ExceptionAndMessage_LogsEntry()
        {
            UNIT.FatalException(logger, EXCEPTION, MESSAGE);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Fatal, EXCEPTION, MESSAGE), Times.Once);
        }

        [Test]
        public void FatalException_ExceptionAndFormatAndArg_LogsEntry()
        {
            UNIT.FatalException(logger, EXCEPTION, MESSAGE, ARG0);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Fatal, EXCEPTION, MESSAGE, ARG0), Times.Once);
        }

        [Test]
        public void FatalException_ExceptionAndFormatAnd2Args_LogsEntry()
        {
            UNIT.FatalException(logger, EXCEPTION, MESSAGE, ARG0, ARG1);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Fatal, EXCEPTION, MESSAGE, ARG0, ARG1), Times.Once);
        }

        [Test]
        public void FatalException_ExceptionAndFormatAnd3Args_LogsEntry()
        {
            UNIT.FatalException(logger, EXCEPTION, MESSAGE, ARG0, ARG1, ARG2);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Fatal, EXCEPTION, MESSAGE, ARG0, ARG1, ARG2), Times.Once);
        }

        [Test]
        public void FatalException_ExceptionAndFormatAnd4Args_LogsEntry()
        {
            UNIT.FatalException(logger, EXCEPTION, MESSAGE, ARG0, ARG1, ARG2, ARG3);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Fatal, EXCEPTION, MESSAGE, ARG0, ARG1, ARG2, ARG3), Times.Once);
        }

        [Test]
        public void FatalException_ExceptionAndMessageGenerator_LogsEntry()
        {
            UNIT.FatalException(logger, EXCEPTION, GENERATOR);
            loggerMock
                .Verify(m => m.LogException(LogLevel.Fatal, EXCEPTION, GENERATOR), Times.Once);
        }
    }
}
