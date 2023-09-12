using System;
namespace FactoryPattern
{
	public class Error : ICallable
	{
		public Error()
		{
		}

        int ICallable.Year { get; set; } = 0;

        void ICallable.Info()
        {
            Console.WriteLine("\nYour phone is not exist");
        }
    }
}

