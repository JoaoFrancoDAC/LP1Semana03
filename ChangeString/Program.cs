using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            
            Console.WriteLine("String:");
            string userString = Console.ReadLine();

            Console.WriteLine("Caráter");
            string userChar = Console.ReadLine();
            
            string modifiedString = userString.Replace(userChar, "x");
            
            Console.WriteLine(modifiedString);
            

        }
    }
}
