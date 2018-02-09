using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator smart = new Calculator();
            for(double a = -5; a<6; a+=0.2)
            {
                for (double b = -5; b < 6; b+=1)
                {
                    Console.WriteLine("{0:F} + {1:F} = {2:F}",a,b,smart.Add(a,b));
                    Console.WriteLine("{0:F} - {1:F} = {2:F}", a, b, smart.Subtract(a, b));
                    Console.WriteLine("{0:F} * {1:F} = {2:F}", a, b, smart.Multiply(a, b));
                    Console.WriteLine("{0:F} ^ {1:F} = {2:F}", a, b, smart.Power(a, b));
                }                    
            }
            Console.ReadKey();
        }
    }
}
