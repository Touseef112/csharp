using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int date;
            string mounth;

            Console.WriteLine("Enter your Date :");
            date = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Mounth :");
            mounth = Console.ReadLine();


            if (mounth == "january" && date > 20 || mounth == "february" && date < 18)
            {
                Console.WriteLine("Your Star is --AQUARIUS--");
            }
            else if (mounth == "february" && date > 19 || mounth == "march" && date < 20)
            {
                Console.WriteLine("YOUR STAR IS --PISCES--");
            }
            else if (mounth == "march" && date > 21 || mounth == "april" && date < 19)
            {
                Console.WriteLine("YOUR STAR IS --ARIES--");
            }
            else if (mounth == "april" && date > 20 || mounth == "may" && date < 20)
            {
                Console.WriteLine("YOUR STAR IS --TAURUS--");
            }
            else if (mounth == "may" && date > 21 || mounth == "june" && date < 20)
            {
                Console.WriteLine("YOUR STAR IS --GEMINI--");
            }
            else if (mounth == "june" && date > 21 || mounth == "july" && date < 22)
            {
                Console.WriteLine("YOUR STAR IS --CANCER--");
            }

            else if (mounth == "july" && date > 23 || mounth == "august" && date < 22)
            {
                Console.WriteLine("Your Star is --LEO--");
            }

            else if (mounth == "august" && date > 23 || mounth == "september" && date < 22)
            {
                Console.WriteLine("YOUR STAR IS --VIRGO--");
            }
            else if (mounth == "september" && date > 23 || mounth == "october" && date < 22)
            {
                Console.WriteLine("YOUR STAR IS --LIBRA--");
            }
            else if (mounth == "october" && date > 23 || mounth == "november" && date < 21) {

                Console.WriteLine("YOUR STAR IS --SCORPIO--" );
            }
            else if (mounth == "november" && date > 22 || mounth == "december" && date < 21) {
                Console.WriteLine("Your Star is --SAGITTARIUS--");
            }
            else if (mounth == "december" && date > 22 || mounth == "january" && date < 19)
            {
                Console.WriteLine("Your Star is --CAPRICON--");

            }
            else
            {
                Console.WriteLine(" Your Entered The Worng Date OR Mounth ");
            }



            Console.ReadLine();

        }
    }
}
