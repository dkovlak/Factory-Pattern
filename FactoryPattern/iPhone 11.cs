using System;
namespace FactoryPattern
{
	public class iPhone_11 : ICallable
	{
        int ICallable.Year { get; set; } = 2019;
                void ICallable.Info()
        {
            Console.WriteLine("\nGreat Choice!" +
                "\n-----iPhone 11-----" +
                $"\n Released: September 20" +
                "\n Weight: 194g" +
                "\n Thickness: 8.3mm");
        }
    }
}

