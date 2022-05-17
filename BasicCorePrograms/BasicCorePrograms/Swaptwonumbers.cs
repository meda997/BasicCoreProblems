using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Swaptwonumbers
    {
    
        public static void Main(string[] args)
        {
            int number1, number2, temp;
            Console.Write("Input the First Number : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Second Number : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.Write("After Swapping : ");
            Console.Write("First Number : " + number1);
            Console.Write("Second Number : " + number2);
            Console.Read();
        }
    }
}
}
