using Moq;
using NUnit.Framework;
using System;

using UNIT = Peons.Logging.LoggerExtensions;

namespace Peons.Logging
{
    [TestFixture]
    public class LoggerExtensionsTests
    {
        const string STRING = "foobar";
        static readonly Exception EXCEPTION = new Exception();
        static readonly Func<string> GENERATOR = new Func<string>(() => STRING);

        ILogger logger;
        LogEntry loggedEntry;

        [SetUp]
        protected void Setup()
        {
            loggedEntry = null;
            var loggerMock = new Mock<ILogger>();
            loggerMock
                .Setup(m => m.Log(It.IsAny<LogEntry>()))
                .Callback<LogEntry>(e => loggedEntry = e);
            logger = loggerMock.Object;
        }

        [Test]
        public void Trace_Message_LogsEntryWithMessage()
        {
            UNIT.Trace(logger, STRING);
            Assert.AreEqual(STRING, loggedEntry.Message);
        }

        [Test]
        public void Trace_MessageAndException_LogsEntryWithMessageAndException()
        {
            UNIT.Trace(logger, STRING, EXCEPTION);
            Assert.AreEqual(STRING, loggedEntry.Message);
            Assert.AreEqual(EXCEPTION, loggedEntry.Exception);
        }

        [Test]
        public void Trace_Exception_LogsEntryWithException()
        {
            UNIT.Trace(logger, EXCEPTION);
            Assert.AreEqual(EXCEPTION, loggedEntry.Exception);
        }

        [Test]
        public void Trace_MessageGenerator_LogsEntryWithMessageGenerator()
        {
            UNIT.Trace(logger, GENERATOR);
            Assert.AreEqual(GENERATOR, loggedEntry.MessageGenerator);
        }

        [Test]
        public void Trace_MessageGeneratorAndException_LogsEntryWithMessageGeneratorAndException()
        {
            UNIT.Trace(logger, GENERATOR, EXCEPTION);
            Assert.AreEqual(GENERATOR, loggedEntry.MessageGenerator);
            Assert.AreEqual(EXCEPTION, loggedEntry.Exception);
        }

        [Test]
        public void Debug_Message_LogsEntryWithMessage()
        {
            UNIT.Debug(logger, STRING);
            Assert.AreEqual(STRING, loggedEntry.Message);
        }

        [Test]
        public void Debug_MessageAndException_LogsEntryWithMessageAndException()
        {
            UNIT.Debug(logger, STRING, EXCEPTION);
            Assert.AreEqual(STRING, loggedEntry.Message);
            Assert.AreEqual(EXCEPTION, loggedEntry.Exception);
        }

        [Test]
        public void Debug_Exception_LogsEntryWithException()
        {
            UNIT.Debug(logger, EXCEPTION);
            Assert.AreEqual(EXCEPTION, loggedEntry.Exception);
        }

        [Test]
        public void Debug_MessageGenerator_LogsEntryWithMessageGenerator()
        {
            UNIT.Debug(logger, GENERATOR);
            Assert.AreEqual(GENERATOR, loggedEntry.MessageGenerator);
        }

        [Test]
        public void Debug_MessageGeneratorAndException_LogsEntryWithMessageGeneratorAndException()
        {
            UNIT.Debug(logger, GENERATOR, EXCEPTION);
            Assert.AreEqual(GENERATOR, loggedEntry.MessageGenerator);
            Assert.AreEqual(EXCEPTION, loggedEntry.Exception);
        }

        [Test]
        public void Info_Message_LogsEntryWithMessage()
        {
            UNIT.Info(logger, STRING);
            Assert.AreEqual(STRING, loggedEntry.Message);
        }

        [Test]
        public void Info_MessageAndException_LogsEntryWithMessageAndException()
        {
            UNIT.Info(logger, STRING, EXCEPTION);
            Assert.AreEqual(STRING, loggedEntry.Message);
            Assert.AreEqual(EXCEPTION, loggedEntry.Exception);
        }

        [Test]
        public void Info_Exception_LogsEntryWithException()
        {
            UNIT.Info(logger, EXCEPTION);
            Assert.AreEqual(EXCEPTION, loggedEntry.Exception);
        }

        [Test]
        public void Info_MessageGenerator_LogsEntryWithMessageGenerator()
        {
            UNIT.Info(logger, GENERATOR);
            Assert.AreEqual(GENERATOR, loggedEntry.MessageGenerator);
        }

        [Test]
        public void Info_MessageGeneratorAndException_LogsEntryWithMessageGeneratorAndException()
        {
            UNIT.Info(logger, GENERATOR, EXCEPTION);
            Assert.AreEqual(GENERATOR, loggedEntry.MessageGenerator);
            Assert.AreEqual(EXCEPTION, loggedEntry.Exception);
        }

        [Test]
        public void Warn_Message_LogsEntryWithMessage()
        {
            UNIT.Warn(logger, STRING);
            Assert.AreEqual(STRING, loggedEntry.Message);
        }

        [Test]
        public void Warn_MessageAndException_LogsEntryWithMessageAndException()
        {
            UNIT.Warn(logger, STRING, EXCEPTION);
            Assert.AreEqual(STRING, loggedEntry.Message);
            Assert.AreEqual(EXCEPTION, loggedEntry.Exception);
        }

        [Test]
        public void Warn_Exception_LogsEntryWithException()
        {
            UNIT.Warn(logger, EXCEPTION);
            Assert.AreEqual(EXCEPTION, loggedEntry.Exception);
        }

        [Test]
        public void Warn_MessageGenerator_LogsEntryWithMessageGenerator()
        {
            UNIT.Warn(logger, GENERATOR);
            Assert.AreEqual(GENERATOR, loggedEntry.MessageGenerator);
        }

        [Test]
        public void Warn_MessageGeneratorAndException_LogsEntryWithMessageGeneratorAndException()
        {
            UNIT.Warn(logger, GENERATOR, EXCEPTION);
            Assert.AreEqual(GENERATOR, loggedEntry.MessageGenerator);
            Assert.AreEqual(EXCEPTION, loggedEntry.Exception);
        }

        [Test]
        public void Error_Message_LogsEntryWithMessage()
        {
            UNIT.Error(logger, STRING);
            Assert.AreEqual(STRING, loggedEntry.Message);
        }

        [Test]
        public void Error_MessageAndException_LogsEntryWithMessageAndException()
        {
            UNIT.Error(logger, STRING, EXCEPTION);
            Assert.AreEqual(STRING, loggedEntry.Message);
            Assert.AreEqual(EXCEPTION, loggedEntry.Exception);
        }

        [Test]
        public void Error_Exception_LogsEntryWithException()
        {
            UNIT.Error(logger, EXCEPTION);
            Assert.AreEqual(EXCEPTION, loggedEntry.Exception);
        }

        [Test]
        public void Error_MessageGenerator_LogsEntryWithMessageGenerator()
        {
            UNIT.Error(logger, GENERATOR);
            Assert.AreEqual(GENERATOR, loggedEntry.MessageGenerator);
        }

        [Test]
        public void Error_MessageGeneratorAndException_LogsEntryWithMessageGeneratorAndException()
        {
            UNIT.Error(logger, GENERATOR, EXCEPTION);
            Assert.AreEqual(GENERATOR, loggedEntry.MessageGenerator);
            Assert.AreEqual(EXCEPTION, loggedEntry.Exception);
        }

        [Test]
        public void Fatal_Message_LogsEntryWithMessage()
        {
            UNIT.Fatal(logger, STRING);
            Assert.AreEqual(STRING, loggedEntry.Message);
        }

        [Test]
        public void Fatal_MessageAndException_LogsEntryWithMessageAndException()
        {
            UNIT.Fatal(logger, STRING, EXCEPTION);
            Assert.AreEqual(STRING, loggedEntry.Message);
            Assert.AreEqual(EXCEPTION, loggedEntry.Exception);
        }

        [Test]
        public void Fatal_Exception_LogsEntryWithException()
        {
            UNIT.Fatal(logger, EXCEPTION);
            Assert.AreEqual(EXCEPTION, loggedEntry.Exception);
        }

        [Test]
        public void Fatal_MessageGenerator_LogsEntryWithMessageGenerator()
        {
            UNIT.Fatal(logger, GENERATOR);
            Assert.AreEqual(GENERATOR, loggedEntry.MessageGenerator);
        }

        [Test]
        public void Fatal_MessageGeneratorAndException_LogsEntryWithMessageGeneratorAndException()
        {
            UNIT.Fatal(logger, GENERATOR, EXCEPTION);
            Assert.AreEqual(GENERATOR, loggedEntry.MessageGenerator);
            Assert.AreEqual(EXCEPTION, loggedEntry.Exception);
        }
    }
}
