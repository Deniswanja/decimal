using System;

namespace AddFiveDecimalNumbers
{
    class Program
    {
        static float[] fivenumbers = { 1, 2, 3, 4, 5 };
        static int count = 0;
        static float value = 0;
        static void Main(string[] args)
        {
            
            while(count<fivenumbers.Length)
            {
                value += fivenumbers[count];
                count += 1;
            }
            Console.WriteLine("Sum of five decimal numbers:{0}",value);
        }
    }
}
