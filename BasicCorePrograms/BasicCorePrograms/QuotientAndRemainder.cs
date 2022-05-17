using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class QuotientAndRemainder
    {
        public void Main(string[] args)
        {
            int num1;
            int num2;
            int quotient;
            int remainder;

            Console.WriteLine("Enter the first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            quotient = num1 / num2;
            remainder = num1 % num2;

            Console.WriteLine("Quotient is : " + quotient);
            Console.WriteLine("Remainder is : " + remainder);
        }
    }
}