using System;

namespace Q1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int temp;

            Console.WriteLine("Enter a temperature");
            temp = int.Parse(Console.ReadLine());

            if (temp >= 18 && temp <= 22)
            {
                Console.WriteLine("this temperature is in the normal range");
            }
            else
            {
                Console.WriteLine("this temperature is outside the normal range");
            }


        }
    }
}
