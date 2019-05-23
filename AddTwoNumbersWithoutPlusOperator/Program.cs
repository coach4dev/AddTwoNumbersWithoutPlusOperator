using System;

namespace AddTwoNumbersWithoutPlusOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The sume of 29 and 33 is: " + Add(29, 33));
            Console.ReadLine();
        }

        static int Add(int a, int b)
        {
            if (b == 0)
                return a;
            int c = a ^ b;
            int d = (a & b) << 1;
            return Add(c, d);
        }
    }
}
