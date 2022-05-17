using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class EvenOdd
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter a Number : ");
            i =Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Entered Number is an Even Number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Entered Number is an Odd Number");
                Console.ReadLine();
            }
        }
    }
}
    
