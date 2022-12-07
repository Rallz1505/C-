using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner
{
    internal class Program
    {
        static object Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Skriv +, -, * eller / ");
            string tegn = Console.ReadLine();
            
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            decimal facit;



            while (1==1)
            {
                if (tegn == "+")
              

                break;

                if (tegn == "/")
                    break;

                if (tegn == "*") 
                break;
                
                    if (tegn == "-")
                Console.Write(num1 - num2);
                Console.ReadLine();
                    
                   
                
               
            }


            while (1 == 1)
            {
                if (tegn == "+") 
                break;

                if (tegn == "/")
                break;

                if (tegn == "-") 
                break;
                
                    if (tegn == "*") 
                    Console.WriteLine(num1 * num2);
                Console.ReadLine();




            }
            while (1 == 1)
            {
                if (tegn == "+") 
                break;

                if (tegn == "*") 
                break;

                if (tegn == "-") 
                break;

                if (tegn == "/")
                   
                Console.WriteLine(num1 /num2);
                Console.ReadLine();




            }
           
            while (1 == 1)
            {
                if (tegn == "-") 
                break;

                if (tegn == "/")
                    break;

                if (tegn == "*") 
                break;

                if (tegn == "+")
                    Console.WriteLine(num1 + num2);
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
