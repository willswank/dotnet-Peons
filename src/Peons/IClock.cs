using System;

namespace Peons
{
	public interface IClock
	{
		DateTime Now { get; }
	}
}
