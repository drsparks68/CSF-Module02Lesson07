using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lastNames = new string[3] { "Sparks", "Vongphonthong", "Mercado" };

            Console.WriteLine("I have a list of three names.  tell me which one you want to know? (1, 2 or 3):");
            string numName = Console.ReadLine();

            bool isValidAge = int.TryParse(numName, out int numberName);

            if (isValidAge)
            {
                if (numberName == 1)
                {
                    Console.WriteLine($"You have chosen number { numberName } which is { lastNames[0] }");
                }
                else if (numberName == 2)
                {
                    Console.WriteLine($"You have chosen number { numberName } which is { lastNames[1] }");
                }
                else
                {
                    Console.WriteLine($"You have chosen number { numberName } which is { lastNames[2] }");
                }
            }

            
            
            
            
            
            
            //string[] firstNames = new string[5];

            //firstNames[0] = "Tim";
            //firstNames[1] = "Tim";
            //firstNames[2] = "Tim";
            //firstNames[3] = "Tim";
            //firstNames[4] = "Tim";

            //string data = "Tim,Sue,Bob,Derek,Allen,Mary,Josephine,Gertrude";
            //string[] firstNames = data.Split(',');

            //Console.WriteLine($"The third first name is { firstNames[2] }");

            //int[] ages = new int[3];
            //ages[0] = 4;
            //ages[1] = 107;
            //ages[2] = 10554;

            //string[] lastNames = new string[] { "Sparks", "Vongphonthong", "Mercado" };
            //lastNames[2] = "";

            Console.ReadLine();
        }
    }
}
