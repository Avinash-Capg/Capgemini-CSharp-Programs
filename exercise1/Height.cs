
using System;

namespace exercise1;

    class Height
    {
        public static void HeightCalculate()
        {
            int height;
            Console.Write("Enter Height in cm : ");
            height = Int32.Parse(Console.ReadLine());

            if (height < 150)
            {
                Console.WriteLine("Dwarf");
            }
            else if (height >= 150 && height <= 165)
            {
                Console.WriteLine("Average");
            }
            else if (height >= 165 && height <= 190)
            {
                Console.WriteLine("Tall");
            }
            else
            {
                Console.WriteLine("Abnormal");
            }
        }
    }

