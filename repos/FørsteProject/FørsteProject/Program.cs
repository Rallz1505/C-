using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FørsteProject
{
    class Hangman
    {
        
        static void fig1()
        {
            Console.WriteLine("  ");
            Console.WriteLine("  +=====+");

        }

        static void fig2()
        {
            Console.WriteLine(" ");
            Console.WriteLine("  +=====+");
            Console.WriteLine("  |     ||");

        }
        static void fig3()
        {
            Console.WriteLine(" ");
            Console.WriteLine("  +=====+");
            Console.WriteLine("  |     ||");
            Console.WriteLine("  O     ||");

        }

        static void fig4()
        {
            Console.WriteLine(" ");
            Console.WriteLine("  +=====+");
            Console.WriteLine("  |     ||");
            Console.WriteLine("  O     ||");
            Console.WriteLine("  |     ||");

        }
        static void fig5()
        {
            Console.WriteLine(" ");
            Console.WriteLine("  +=====+");
            Console.WriteLine("  |     ||");
            Console.WriteLine("  O     ||");
            Console.WriteLine("  |     ||");
            Console.WriteLine(" \\|/    ||");
           

        }    
        static void fig6()
        {
            Console.WriteLine(" ");
            Console.WriteLine("  +=====+");
            Console.WriteLine("  |     ||");
            Console.WriteLine("  O     ||");
            Console.WriteLine("  |     ||");  
            Console.WriteLine(" \\|/    ||");
            Console.WriteLine(" / \\    ||");

        }
        static void fig7()
        {
            Console.WriteLine(" ");
            Console.WriteLine("  +=====+");
            Console.WriteLine("  |     ||");
            Console.WriteLine("  O     ||");
            Console.WriteLine("  |     ||");
            Console.WriteLine(" \\|/    ||");
            Console.WriteLine(" / \\    ||");
            Console.WriteLine("     ___||___");

        }
         
        static void hangMand(int nr)
        {
            switch (nr)
            {
                case 1:
                    fig1();
                    break;

                case 2:
                    fig2();
                    break;

                case 3:
                    fig3();
                    break;

                case 4:
                    fig4();
                    break;

                case 5:
                    fig5();
                    break;

                case 6:
                    fig6();
                    break;

                case 7:
                    fig7();
                    break;
            }

        }
        static void Main()
        {
            char[] array1 = { 'e', 'f', 't', 'e', 'r', 's', 'k', 'o', 'l', 'e' };
            char[] array2 = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
            int ind = 0;
            int længde = array1.Length;
            int forsøg = 0;
            char myChar;
            int korrektCnt = 0;
            int fejl = 0;
            
            while (1 == 1)
            {

                Console.Write("tast et bogstav ->");
                myChar = Console.ReadKey().KeyChar;
                Console.WriteLine();


                while (1 == 1)
                {
                    if (myChar == array1[ind])
                    {
                        if (array2[ind] == ' ')
                            korrektCnt++;
                        array2[ind] = array1[ind];
                    }

                    ind++;

                    if (ind == længde)
                        break;
                }
                ind = 0;

                while (ind < længde)
                {
                    Console.Write(array2[ind]);
                    ind++;
                }
                ind = 0;

                if (korrektCnt == længde)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Tillykke du har redet Theo");
                    break;
                }
                fejl++;
                forsøg++;
                Console.WriteLine("                     Du har brugt " + forsøg + " forsoeg");
                if (fejl == 7)
                    Console.WriteLine("       Tillykke du har dræbt Theo");
                hangMand(fejl);
            }

            Console.ReadLine();    

        }
    }
} 