using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Peons.Web
{
    public class UserIpAddressSniffer : IUserIpAddressSniffer
    {
        private readonly IHttpContextProvider httpContextProvider;

        public UserIpAddressSniffer(IHttpContextProvider httpContextProvider)
        {
            if (httpContextProvider == null)
                throw new ArgNullException(() => httpContextProvider);

            this.httpContextProvider = httpContextProvider;
        }

        public string GetUserIpAddress()
        {
            var httpContext = this.httpContextProvider.GetCurrentHttpContext();
            var serverVariables = httpContext.Request.ServerVariables;
            var forwardedIpChain = serverVariables["HTTP_X_FORWARDED_FOR"];
            string ipAddress;
            if (!string.IsNullOrWhiteSpace(forwardedIpChain))
            {
                ipAddress = forwardedIpChain.Split(',').First();
            }
            else
            {
                ipAddress = httpContext.Request.UserHostAddress;
            }
            return ipAddress;
        }
    }
}
