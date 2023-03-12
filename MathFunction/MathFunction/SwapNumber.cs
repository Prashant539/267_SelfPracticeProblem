using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunction
{
    public class SwapNumber
    {
        int a, b, temp;

        public void SwapNumberPrint()
        {
            Console.WriteLine("Enter the First Number to Swap: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number to Swap: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before the Swap a = {0}, b = {1}", a, b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After the Swap a = {0}, b = {1}", a, b);
        }
    }
}
