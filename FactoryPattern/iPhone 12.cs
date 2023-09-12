using System;
namespace FactoryPattern
{
	public class iPhone_12 : ICallable
	{
		public iPhone_12()
		{
		}

        int ICallable.Year { get; set; } = 2020;

        void ICallable.Info()
        {
            Console.WriteLine("\nGreat Choice!" +
                "\n-----iPhone 12-----" +
                "\n Released: October 23" +
                "\n Weight: 164g" +
                "\n Thickness: 7.4mm");
        }
    }
}

