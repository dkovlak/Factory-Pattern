using System;
namespace FactoryPattern
{
	static class AppleFactory
	{
		public static ICallable NewiPhone(string choice)
		{
			switch (choice.ToLower())
			{
				case "iphone x"
					:return new iPhone_X();
				case "ipnone 11"
					:return new iPhone_11();
				case "iphone 12"
					:return new iPhone_12();
				case "iphone 13"
					:return new iPhone_13();
				case "iphone 14"
					:return new iPhone_14();
				default
					:return new Error();
			}
		}
	}
}

