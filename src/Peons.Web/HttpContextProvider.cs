using System.Web;

namespace Peons.Web
{
	public class HttpContextProvider : IHttpContextProvider
	{
		public HttpContextWrapper GetCurrentHttpContext()
		{
			var httpContext = HttpContext.Current;
			var wrapped = new HttpContextWrapper(httpContext);
			return wrapped;
		}
	}
}
