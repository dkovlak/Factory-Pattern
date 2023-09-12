using System;
namespace FactoryPattern
{
	public class iPhone_X : ICallable
	{
		public iPhone_X()
		{
		}

        int ICallable.Year { get; set; } = 2017;

        public void Info()
        {
            Console.WriteLine("\nGreat Choice!" +
                "\n-----iPhone X-----" +
                "\n Released: November 03" +
                "\n Weight: 174g" +
                "\nThickness: 7.7");
        }
    }
}

