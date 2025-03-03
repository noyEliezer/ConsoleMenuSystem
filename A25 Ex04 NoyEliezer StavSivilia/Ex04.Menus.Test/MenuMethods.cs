using System;

namespace Ex04.Menus.Test
{
    public class MenuMethods
    {
        internal static void ShowVersion()
        {
            Console.WriteLine("> App Version: 25.1.4.5480");
        }

        internal static void ShowCurrentTime()
        {
            Console.WriteLine(string.Format("> Current time: {0:HH:mm:ss}", DateTime.Now));
        }

        internal static void ShowCurrentDate()
        {
            Console.WriteLine(string.Format("> Current Date: {0:dd/MM/yyyy}", DateTime.Now));
        }

        internal static void CountLowercaseLetters()
        {
            Console.WriteLine("Please enter your sentence:");
            string input = Console.ReadLine();
            int lowercaseCount = 0;

            foreach (char c in input)
            {
                if (char.IsLower(c))
                {
                    lowercaseCount++;
                }
            }

            Console.WriteLine($"> There are {lowercaseCount} lowercase letters in your text");
        }
    }
}
