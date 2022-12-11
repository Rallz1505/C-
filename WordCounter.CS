using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounters
{
    internal class Program
    {
            // Hej Flexfone, her er min opgave :) Jeg er selv meget tilfreds med den. Er dog godt klar over jeg er utroligt dårlig til at sætte mit kode pænt op :) Håber i kan lide den :)
            
        static void Main(string[] args)
        {
            //Denne While sørger for at koden gå på ny hver gang du skriver "Ja" hvilket vi vil komme til længere nede
            while (1==1) 
            {
                //Introduktion
                Console.WriteLine("Hej FlexFone, nu skal i teste min Word Counter, vær sød at skrive en sætning :");

                //Gemmer hvad man skriver i en string ved navn Input
                string input = Console.ReadLine();

                //Laver et string array hvorefter at alt du har skrevet bliver sat ind i array ved hjælp af split, den splitter hver gang man laver et mellemrum
                string[] InputArray = input.Split(' ');

                //Giver en var med navnet totalElements værdien af hvor mange ord der er i dit array ved hjælp af InputArray.Count
                var totalElements = InputArray.Count();

                //forklarer bare forbrugeren hvad de skal skrive og hvor mange ord de har skrevet
                Console.WriteLine("Du har skrevet " + totalElements + " ord");
                Console.WriteLine("Ønsker du at prøve igen skriv: Ja ");
                Console.WriteLine("ønsker du at slutte skriv: Nej");

                //Gemmer ens svar i en string ved navnet Svar
                string Svar = Console.ReadLine();
                //Sørger for at det er ligemeget om man skriver med stort eller småt
                Svar = Svar.ToLower();


                //Sørger for at hvis du skriver "Ja" forsætter du med at "spille" og clear alt der var før på consolen.
                if (Svar == "ja")
                {
                    Console.Clear();
                    

                }
                // Hvis du skriver noget andet end "Ja" Breaker den loopet som der kør "forevigt"
                else
                {
                    break;
                }
            }
        }
    }
}
