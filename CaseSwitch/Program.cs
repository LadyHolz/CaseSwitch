using System;

namespace CaseSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numer");
            int intNum = Convert.ToInt32(Console.ReadLine());   

            switch (intNum)
            {
                case 19:
                    Console.WriteLine("You are 19");
                    break;
                case 20:
                    Console.WriteLine("You are 20");
                    break;
                default:
                    Console.WriteLine("Your not 19 or 20");
                    break;

            }
        }
    }
}
