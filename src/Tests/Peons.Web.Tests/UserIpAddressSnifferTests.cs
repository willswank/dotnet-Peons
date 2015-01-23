using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using System.Web;
using System.Collections.Specialized;

namespace Peons.Web
{
    [TestFixture]
    public class UserIpAddressSnifferTests
    {
        UserIpAddressSniffer unit;

        NameValueCollection serverVariablesInput;
        Mock<HttpRequestBase> httpRequestBaseMock;
        Mock<HttpContextBase> httpContextBaseMock;
        Mock<IHttpContextProvider> httpContextProviderMock;

        [SetUp]
        protected void Setup()
        {
            serverVariablesInput = new NameValueCollection();
            httpRequestBaseMock = new Mock<HttpRequestBase>();
            httpRequestBaseMock
                .Setup(h => h.ServerVariables)
                .Returns(serverVariablesInput);
            httpContextBaseMock = new Mock<HttpContextBase>();
            httpContextBaseMock
                .Setup(h => h.Request)
                .Returns(httpRequestBaseMock.Object);
            httpContextProviderMock = new Mock<IHttpContextProvider>();
            httpContextProviderMock
                .Setup(m => m.GetCurrentHttpContext())
                .Returns(httpContextBaseMock.Object);
            unit = new UserIpAddressSniffer(httpContextProviderMock.Object);
        }

        [Test]
        public void ctor_NullHttpContextProvider_ThrowsException()
        {
            var action = new TestDelegate(() => new UserIpAddressSniffer(null));
            Assert.Throws<ArgNullException>(action);
        }

        [Test]
        public void GetUserIpAddress_IpAddressInHttpXForwardedForServerVariable_ReturnsIpAddress()
        {
            var input = "foobar";
            serverVariablesInput.Add("HTTP_X_FORWARDED_FOR", input);
            var output = unit.GetUserIpAddress();
            Assert.AreEqual(input, output);
        }

        [Test]
        public void GetUserIpAddress_CommaSeparatedListOfIpAddressesInHttpXForwardedForServerVariable_ReturnsFirstIpAddress()
        {
            var input = "foo";
            serverVariablesInput.Add("HTTP_X_FORWARDED_FOR", input + ",bar");
            var output = unit.GetUserIpAddress();
            Assert.AreEqual(input, output);
        }

        [Test]
        public void GetUserIpAddress_NoHttpXForwardedServerVariable_ReturnsRequestUserHostAddress()
        {
            var input = "foobar";
            httpRequestBaseMock
                .Setup(m => m.UserHostAddress)
                .Returns(input);
            var output = unit.GetUserIpAddress();
            Assert.AreEqual(input, output);
        }
    }
}
