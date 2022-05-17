using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class FlipCoin
    {
        public int Head = 0;
        public int Tail = 0;
        public Double Percentofhead;
        public Double Percentoftail;
        public int Coinflip;
        public void FlipaCoin()
        {
            Console.WriteLine("Enter How many times do you want to flip a coin");
            int number = Convert.ToInt32(Console.ReadLine());
            {
                if (number <= 0)
                {
                    Console.WriteLine("Please enter a correct positive number");
                }
                else
                {
                    for (int i = 0; i < number; i++)
                    {
                        Random RandomNumber = new Random();
                        float Random_Number = (float)RandomNumber.NextDouble();
                        if (Random_Number < 0.5)
                        {
                            Head++;
                        }
                        else
                        {
                            Tail++;
                        }

                    }
                    Console.WriteLine("Number of Heads occurred: " + Head);
                    Console.WriteLine("Number of Tails occurred: " + Tail);
                    Percentofhead = (Head / Convert.ToDouble(Coinflip)) * 100;
                    Percentoftail = (Tail / Convert.ToDouble(Coinflip)) * 100;
                    Console.WriteLine("Total Percent of getting Heads: {Percentofhead}%");
                    Console.WriteLine("Total Percent of getting Heads: {Percentoftail}%");
                }
            }
        }
    }
}