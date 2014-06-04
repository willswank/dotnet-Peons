using System;

namespace Peons
{
	public class LocalClock : IClock
	{
		public DateTime Now
		{
			get { return DateTime.Now; }
		}
	}
}
