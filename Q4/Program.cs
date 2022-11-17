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
