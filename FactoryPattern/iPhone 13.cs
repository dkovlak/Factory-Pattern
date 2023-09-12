using System;
namespace FactoryPattern
{
	public class iPhone_13 : ICallable
	{
		public iPhone_13()
		{
		}

        int ICallable.Year { get; set; } = 2021;

        void ICallable.Info()
        {
            Console.WriteLine("\nGreat Choice!" +
                "\n-----iPhone 13-----" +
                "\n Released: September 14" +
                "\n Weight: 174g" +
                "\n Thickness: 7.65mm");
        }
    }
}

