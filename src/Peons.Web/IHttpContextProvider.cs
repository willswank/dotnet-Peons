using System.Web;

namespace Peons.Web
{
	public interface IHttpContextProvider
	{
		HttpContextWrapper GetCurrentHttpContext();
	}
}
