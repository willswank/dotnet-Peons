﻿using System;
using System.Collections.Generic;

namespace Peons.NUnit.Internals
{
	public class Builder<T>
	{
		public IEnumerable<T> Inputs { get; set; }
		public Action<T> Setter { get; set; }
	}
}
