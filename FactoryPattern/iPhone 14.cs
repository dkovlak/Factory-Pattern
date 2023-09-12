using System;
namespace FactoryPattern
{
	public class iPhone_14 : ICallable
	{
		public iPhone_14()
		{
		}

		int ICallable.Year { get; set; } = 2023;

        void ICallable.Info()
        {
            Console.WriteLine("\nGreat Choice!" +
                "\n-----iPhone 14-----" +
                "\n Released: September 16" +
                "\n Weight: 177g" +
                "\n Thickness: 7.7mm");
        }
    }
}

