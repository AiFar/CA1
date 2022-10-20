# CA1

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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Q3
{
    class MainClass
    {
        private static string path;

        public static void Main(string[] args)
        {
            //read in file contents using File.ReadAllLines

            //Print headers

            //Loop through each line in file

            //Extract contents of each line

            //Split line with descriptors using String.Split using a comma to split

            //Output details


            string filePath = "Ibans.scpt";
            string[] fileContents = File.ReadAllLines(filePath);

            //Console.WriteLine("Bank Code");

            //Console.WriteLine("Sort Code");

            //Console.WriteLine("Account Number");

            var lines = File.ReadAllLines(filePath);
            var firstLine = lines[8];
            var fields = firstLine.Split(',');
            
        }
    }
}

using System;

namespace Q4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double[,] rainFall = new double[,]
          {
                {6.9, 7.1, 7.2},
                {6.1, 6.4, 6.3},
                {6.5, 6.7, 6.9}
          };

            double[] averages = new double[3];

            double total;

            for (double i = 0; i < rainFall.GetLength(0); i++)
            {
                total = 0;

                for (double j = 0; j < rainFall.GetLength(1); j++)
                {
                    total += rainFall[i, j];
                }

                averages[i] = (double)total / 3;
            }

            foreach (double average in averages)
            {
                Console.WriteLine($"Average is {average:F2}");
            }
        }
    }
}

using System;

namespace Q6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ElectricBike B1 = new ElectricBike();
            B1.ID = "EB1";
            B1.Location = "Ash Lane";
            B1.BatteryPercentage = 50;



            ElectricBike B2 = new ElectricBike();
            B2.ID = "EB2";
            B2.Location = "Strandhill";
            B2.BatteryPercentage = 10;





        }
    }
}

using System;
namespace Q6
{
    public class ElectricBike
    {
        public ElectricBike()
        {
        }

        private string id;

        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        private string location;

        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        private int batteryPercentage;

        public int BatteryPercentage
        {
            get { return this.batteryPercentage; }
            set { this.batteryPercentage = value; }
        }
    }
}
