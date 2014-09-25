using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace Peons.Rules
{
    [TestFixture]
    class EnforcerTests
    {
        Enforcer unit;

        [SetUp]
        protected void Setup()
        {
            unit = new Enforcer();
        }

        [Test]
        public void GetBrokenRule_NullRuleArray_ThrowException()
        {
            var action = new TestDelegate(() => unit.GetBrokenRule((IRule<int>[])null, 42));
            Assert.Throws<ArgNullException>(action);
        }

        [Test]
        public void GetBrokenRule_RuleArray_AppliesEachRuleInOrder()
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
        public void GetBrokenRule_RuleArray_ReturnsFirstBrokenRule()
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

        [Test]
        public void GetBrokenRule_NullRuleList_ThrowException()
        {
            var action = new TestDelegate(() => unit.GetBrokenRule((IRuleList<int>)null, 42));
            Assert.Throws<ArgNullException>(action);
        }

        [Test]
        public void GetBrokenRule_RuleList_AppliesEachRuleInOrder()
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
            var ruleListMock = new Mock<IRuleList<int>>();
            ruleListMock.Setup(m => m.Rules)
                .Returns(inputRules.ToArray());
            unit.GetBrokenRule(ruleListMock.Object, 42);
            for (var i = 0; i < 5; i++)
            {
                Assert.AreEqual(i, invokedOrderOutput[i]);
            }
        }

        [Test]
        public void GetBrokenRule_RuleList_ReturnsFirstBrokenRule()
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
            var ruleListMock = new Mock<IRuleList<int>>();
            ruleListMock.Setup(m => m.Rules)
                .Returns(inputRules);
            var output = unit.GetBrokenRule(ruleListMock.Object, 42);
            Assert.AreEqual(inputRuleCMock.Object, output);
        }
    }
}
