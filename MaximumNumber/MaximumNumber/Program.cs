﻿using System;

namespace MaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generic Implementation");


            Console.WriteLine("Find max Number");
            int output = MaximumNumberCheck.MaximumIntegerNumber(11, 22, 33);
            Console.WriteLine(output);
            double doubleoutput = MaximumNumberCheck.MaximumFloatNumber(111.2, 22.45, 78.56);
            Console.WriteLine(doubleoutput);

            Console.ReadKey();
        }
    }
}
