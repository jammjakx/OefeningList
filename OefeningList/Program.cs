using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Info over het project weergeven
            Console.WriteLine("**************************************************");
            Console.WriteLine("Project: oefeningArray");
            Console.WriteLine("Auteur: Ralph Verspui    Datum:  24 Okt. 2016");
	        Console.WriteLine("**************************************************");

            // List with fruits
            List<string> lijst = new List<string>();
            lijst.Add("appel");
            lijst.Add("peer");
            lijst.Add("banaan");
            lijst.Add("perzik");
            lijst.Add("druif");
           

            // print the list 
            Console.WriteLine(Environment.NewLine + "List contains: ");
            foreach (string s in lijst)
            {
                Console.WriteLine(s);
            }

            //make changes to the list
            Console.WriteLine(Environment.NewLine + "The list is currently being changed:");
                lijst[0] = "aardappel";
            Console.WriteLine("- appel vervangen door aardappel");

            lijst.RemoveAt(3);
            Console.WriteLine("- perzik verwijderd -> (appel=0, peer=1, banaan=2, perzik=3)");

            //print the array
            Console.WriteLine(Environment.NewLine + "Array list contains");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(lijst[i]);
            }


            Console.ReadLine();
        } 
    }
}
