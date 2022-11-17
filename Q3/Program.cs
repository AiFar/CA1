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
