using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Jan15th
{
    class GenerationFinder
    {

        public string determination(string year)
        {
            var formatter = " ";
            if (year.Length <= 3 || Convert.ToInt32(year) < 1901 || year == " ")
            {
                Console.Write("Invalid year given: " + year);
            }
            else if (Convert.ToInt32(year) >= 1901 && Convert.ToInt32(year) <= 1926)
            {
                Console.WriteLine("GI Generation: " + year);
            }
            else if (Convert.ToInt32(year) >= 1927 && Convert.ToInt32(year) <= 1945)
            {
                Console.WriteLine("Mature/Silents: " + year);

            }
            else if (Convert.ToInt32(year) >= 1946 && Convert.ToInt32(year) <= 1964)
            {
                Console.WriteLine("Baby Boomers: " + year);

            }
            else if (Convert.ToInt32(year) >= 1965 && Convert.ToInt32(year) <= 1980)
            {
                Console.WriteLine("Generation X: " + year);

            }
            else if (Convert.ToInt32(year) >= 1981 && Convert.ToInt32(year) <= 2000)
            {
                Console.WriteLine("Generation Y: " + year);

            }
            else
            {
                Console.WriteLine("Generation Z: " + year);
            }

            return formatter;
        }
    }
}
