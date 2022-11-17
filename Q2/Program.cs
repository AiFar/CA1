using System;

namespace Q2
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("Which membership do you want to purchase?");
            string input = Console.ReadLine();

            int discount;

            switch (input)
            {
                case "children":
                    discount = (int)0.50;
                    break;
                case "students":
                    discount = (int)0.20;
                    break;
                case "OAPS":
                    discount = (int)0.10;
                    break;
                default:
                    discount = 0;
                    break;
            }


        }
    }
}
