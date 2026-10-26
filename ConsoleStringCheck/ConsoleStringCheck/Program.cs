using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStringCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sAusbildungsname = "";
            string sWachposten1 = "\tWachposten: (Ein muskulöser Elf im Panzer) Wer da? Nur Mitglieder mit einer anerkannten \n\tBerufsbezeichnung dürfen passieren.";
            string sAbenteurer1 = "\tAbenteurer: (Spieler) Ich bin bereit.";
            string sWachposten2 = "\tWachposten: Nenne mir die exakte Bezeichnung deiner letzten Krieger-Ausbildung.";
            string sWarnung = "\tAchtung: Es ist eine einzige, ununterbrochene Zeichenkette! \n\t" +
                              "Groß- und Kleinschreibung muss vollständig beachtet werden.";
            string sNameTrue = "\tKorrekt";
            string sNameFalse = "\tFalsch";


            Console.WriteLine(sWachposten1);
            Console.ReadLine();

            Console.WriteLine(sAbenteurer1);
            Console.ReadLine();

            Console.WriteLine(sWachposten2);
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(sWarnung);
            Console.ForegroundColor = ConsoleColor.White;

            sAusbildungsname = Console.ReadLine();
            string sWachposten3 = "\n\tDu sagst, du bist ein " + sAusbildungsname + ". \n\tIch werde diese Zeichenkette nun mit unserer Liste vergleichen";

            Console.WriteLine(sWachposten3);
            Console.ReadLine();

            if (sAusbildungsname == "EisenfaustMeister")

            {
                Console.WriteLine(sNameTrue);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(sNameFalse);
                Console.ReadLine();
            }
        }
    }
}