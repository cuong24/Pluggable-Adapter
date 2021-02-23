using System;

// New standard for requests
namespace Pluggable_Adapter
{

	class Client
	{

		static void Main()
		{

			Adapter adapter1 = new Adapter(new Adaptee());
			Console.WriteLine(adapter1.Request(5));

			Adapter adapter2 = new Adapter(new AnotherAdaptee());
			Console.WriteLine(adapter2.Request(5));

		}
	}
}