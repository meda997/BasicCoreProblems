﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Leapyear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year : ");
            int Year = Convert.ToInt32(Console.ReadLine());
            {
                if ((Year % 4 == 0) && (Year % 400 == 0))
                    Console.WriteLine("{0} is a Leap Year.", Year);


                else

                    Console.WriteLine("{0} is not a Leap Year.", Year);
                Console.ReadLine();
            }
        }
    }

}