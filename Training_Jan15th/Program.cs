using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Jan15th
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerationFinder generation = new GenerationFinder();

            do
            {
                Console.WriteLine("Enter years of when people were born:");
                string nums = Console.ReadLine();
                string[] input = nums.Split(' ');

                foreach (string year in input)
                {
                   Console.WriteLine(generation.determination(year));
                }

                Console.ReadKey();

            } while (true);

        }
    }

}
