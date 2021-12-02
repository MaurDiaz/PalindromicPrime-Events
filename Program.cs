using System;

namespace ActivityE5
{
    class Program
    {
        static void Main(string[] args)
        {
           UserInput value = new UserInput();
           value.PrimeEvent += Notify;
           value.PalindromeEvent += Notify;
           string input;
           do{
                Console.WriteLine("Enter a positive integer or 'exit' to end:");
                input = Console.ReadLine();
                value.Number = input;
           }while(input != "exit");
        }
        static void Notify(string message)
        {
            
            Console.WriteLine(message);
        }
    }
}
