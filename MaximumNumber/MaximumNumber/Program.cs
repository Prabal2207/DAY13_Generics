using System;

namespace MaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generic Implementation");


            string maximum = MaximumNumberCheck.FindMaximum<int>(12, 16, 14);
            string maximum1 = MaximumNumberCheck.FindMaximum<float>(111.2f,22.45f,78.56f);
            string maximum2 = MaximumNumberCheck.FindMaximum<string>("22", "33", "44");

            Console.WriteLine(maximum);
            Console.WriteLine(maximum1);
            Console.WriteLine(maximum2);
            Console.ReadKey();

            //Console.WriteLine("Find max Number");
            //int output = MaximumNumberCheck.MaximumIntegerNumber(11, 22, 33);
            //Console.WriteLine(output);
            //double doubleoutput = MaximumNumberCheck.MaximumFloatNumber(111.2, 22.45, 78.56);
            //Console.WriteLine(doubleoutput);
            //string strigoutput = MaximumNumberCheck.MaximumStringNumber("22", "33", "44");
            //Console.WriteLine(strigoutput);

            Console.ReadKey();
        }
    }
}
