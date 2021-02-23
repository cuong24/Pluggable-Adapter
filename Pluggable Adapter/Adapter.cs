
using System;
using System.Collections.Generic;
using System.Text;

namespace Pluggable_Adapter
{
	// Implementing new requests via old
	class Adapter
	{
		public Func<int, string> Request;

		// Different constructors for the expected targets/adaptees

		// Adapter-Adaptee
		public Adapter(Adaptee adaptee)
		{
			// Set the delegate to the new standard
			Request = x =>
			{
				return "Estimate based on precision is " + (int)Math.Round(adaptee.Precise(x, 3));
			};
		}

		// Adapter-Target
		public Adapter(AnotherAdaptee adaptee)
		{
			// Set the delegate to the existing standard
			Request = adaptee.Estimate;
		}
	}
}
