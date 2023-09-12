namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~ Welcome to Apple ~~~~~~~~~~");
            Console.WriteLine("\nWhat iPhone whould you like to buy?");
            string userInput = Console.ReadLine();

            ICallable iphone = AppleFactory.NewiPhone(userInput);
            iphone.Info();
            Console.WriteLine($"Year: {iphone.Year}");
        }
    }
}
