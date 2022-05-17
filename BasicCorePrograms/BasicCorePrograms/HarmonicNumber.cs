using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class HarmonicNumber
    {
        int i;
        public void Harmonic()
        {

            Console.Write("Enter the number of terms : ");
            int Harmonic = Convert.ToInt32(Console.ReadLine());
            if (Harmonic == 0)
            {
                Console.WriteLine("Harmonic can not be zero");
            }
            else
            {
                Console.Write("Harmonics are: ");
                for (i = 1; i <= Harmonic; i++)
                {
                    Console.Write("1/{0} + ", i);
                }

            }
        }
    }
}