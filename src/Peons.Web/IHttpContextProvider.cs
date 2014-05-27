using System.Web;

namespace Peons.Web
{
	public interface IHttpContextProvider
	{
		HttpContextBase GetCurrentHttpContext();
	}
}
