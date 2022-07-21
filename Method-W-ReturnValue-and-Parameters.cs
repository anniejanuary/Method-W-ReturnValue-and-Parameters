using System;

namespace MethodsWReturnValueandParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divide(95,13));
                
        }

        public static double Divide(double num1, double num2)
        {
            return (double)num1 / (double)num2;
        }
    }
}
