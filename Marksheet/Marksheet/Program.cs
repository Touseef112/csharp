using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marksheet
{
    class Program
    {
        static void Main(string[] args)
        {
            int math;
            int physics;
            int chemistry;
            int english;
            int urdu;

            Console.Write("ENTER YOUR MATH MARKS :  ");
            math = int.Parse(Console.ReadLine());

            Console.Write("ENTER YOUR PHYSICS MARKS :  ");
            physics = int.Parse(Console.ReadLine());

            Console.Write("ENTER YOUR CHEMISRY MARKS :  ");
           chemistry = int.Parse(Console.ReadLine());

            Console.Write("ENTER YOUR ENGLISH MARKS :  ");
            english= int.Parse(Console.ReadLine());

            Console.Write("ENTER YOUR URDU MARKS :  ");
            urdu = int.Parse(Console.ReadLine());

            int obtain = math + physics + chemistry + english + urdu;
            int total = 500;
            Console.WriteLine("your obtain marks is = "+obtain+ "  upto total marks = " +total);       
        
            float percentage = obtain / total * 100;
            Console.WriteLine( +percentage );

            if (math < 100)
            {
                if (physics < 100)
                {
                    if (chemistry < 100)
                    {
                        if (english < 100)
                        {
                            if (urdu < 100)
                            { 
                                if (percentage >= 80)
                                {
                                    Console.WriteLine("A1 GRADE:");

                                if (percentage >= 70)
                                    {
                                        Console.WriteLine("A GRADE:");


                                 if (percentage >= 60)
                                        {
                                            Console.WriteLine("B GRADE:");
                                        }

                                    }
                               }
                            }
                        }
                    }

                }         
            
            }

            else
            {
                Console.WriteLine("You Entered the Worng Marks :");
            }

            Console.ReadLine();
        }
    }
}
