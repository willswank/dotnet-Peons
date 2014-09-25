using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace Peons.Rules
{
    [TestFixture]
    class EnforcerTests
    {
        Enforcer<int> unit;

        [SetUp]
        protected void Setup()
        {
            unit = new Enforcer<int>();
        }

        [Test]
        public void GetBrokenRule_NullRules_ThrowException()
        {
            var action = new TestDelegate(() => unit.GetBrokenRule(null, 42));
            Assert.Throws<ArgNullException>(action);
        }

        [Test]
        public void GetBrokenRule_AppliesEachRuleInOrder()
        {
            var invokedOrderOutput = new List<int>();
            var ruleMocks = new List<Mock<IRule<int>>>();
            var inputRules = new List<IRule<int>>();
            for (var i = 0; i < 5; i++)
            {
                var mock = new Mock<IRule<int>>();
                var value = i;
                mock.Setup(m => m.AppliesTo(It.IsAny<int>()))
                    .Callback(() => invokedOrderOutput.Add(value))
                    .Returns(true);
                ruleMocks.Add(mock);
                inputRules.Add(mock.Object);
            }
            unit.GetBrokenRule(inputRules.ToArray(), 42);
            for (var i = 0; i < 5; i++)
            {
                Assert.AreEqual(i, invokedOrderOutput[i]);
            }
        }

        [Test]
        public void GetBrokenRule_ReturnsFirstBrokenRule()
        {
            var inputRuleAMock = new Mock<IRule<int>>();
            var inputRuleBMock = new Mock<IRule<int>>();
            var inputRuleCMock = new Mock<IRule<int>>();
            var inputRuleDMock = new Mock<IRule<int>>();
            var inputRuleEMock = new Mock<IRule<int>>();
            inputRuleAMock.Setup(m => m.AppliesTo(It.IsAny<int>()))
                .Returns(true);
            inputRuleBMock.Setup(m => m.AppliesTo(It.IsAny<int>()))
                .Returns(true);
            inputRuleCMock.Setup(m => m.AppliesTo(It.IsAny<int>()))
                .Returns(false);
            inputRuleDMock.Setup(m => m.AppliesTo(It.IsAny<int>()))
                .Returns(false);
            inputRuleEMock.Setup(m => m.AppliesTo(It.IsAny<int>()))
                .Returns(true);
            var inputRules = new IRule<int>[]
            {
                inputRuleAMock.Object,
                inputRuleBMock.Object,
                inputRuleCMock.Object,
                inputRuleDMock.Object,
                inputRuleEMock.Object
            };
            var output = unit.GetBrokenRule(inputRules, 42);
            Assert.AreEqual(inputRuleCMock.Object, output);
        }
    }
}
