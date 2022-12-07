using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Skriv +, -, * eller / ");
            string tegn = Console.ReadLine();

            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());


            string[] Tegn = new string[5];
            Tegn[0] = "+";

            while (1 == 1)
            {
              
                if (tegn == "-")
                    Console.Write(num1 - num2);
               


                else
                    break;
                Console.ReadLine();


            }


            while (1 == 1)
            {
        

                if (tegn == "*")
                    Console.WriteLine(num1 * num2);
               
                else
                    break;
                Console.ReadLine();




            }
            while (1 == 1)
            {
            

                if (tegn == "/")

                    Console.WriteLine(num1 / num2);
                
                else
                    break;
                Console.ReadLine();





            }

            while (1 == 1)
            {
               

                if (tegn == Tegn[0])
                    Console.WriteLine(num1 + num2);
                else
                    break;
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
  