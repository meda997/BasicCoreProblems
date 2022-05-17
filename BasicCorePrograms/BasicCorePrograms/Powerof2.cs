using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Powerof2
    {
        public void PowerTwo()
        {
            Console.WriteLine("Enter power value of 2:");
            int Pow = Convert.ToInt32(Console.ReadLine());
            if (0 <= Pow || Pow <= 31)
            {
                for (int i = 0; i < Pow; i++)
                {
                    Console.WriteLine("2^{0}={1}", i, Math.Pow(2, i));
                }
            }
            else
            {
                Console.WriteLine("Enter a value within range: 0 to 31");
            }
        }
    }
}