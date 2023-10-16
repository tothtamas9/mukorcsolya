using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace mukorcsolya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. feladat:

            //rovidprogram.csv beolvasása és eltárolása
            List<Rovidprogram> adatok = new List<Rovidprogram>();
            string[] olvasottAdatok = File.ReadAllLines("source\\rovidprogram.csv");

            for (int i = 1; i < olvasottAdatok.Length; i++)
            {
                string ujSor = olvasottAdatok[i].Replace('.', ',');
                string[] tag = ujSor.Split(';');
                Rovidprogram ujAdat = new Rovidprogram(tag[0], tag[1], Convert.ToDouble(tag[2]), Convert.ToDouble(tag[3]), Convert.ToInt32(tag[4]));
                adatok.Add(ujAdat);
            }

            //donto.csv beolvasása és eltárolása
            List<Donto> dontosok = new List<Donto>();
            string[] olvasottDontosok = File.ReadAllLines("source\\donto.csv");

            for (int i = 1; i < olvasottDontosok.Length; i++)
            {
                string ujSor = olvasottAdatok[i].Replace('.', ',');
                string[] tag = ujSor.Split(';');
                Donto ujDontos = new Donto(tag[0], tag[1], double.Parse(tag[2]), double.Parse(tag[3]), int.Parse(tag[4]));
                dontosok.Add(ujDontos);
            }

            //2. feladat:
            Console.WriteLine("2. feladat");
            Console.WriteLine($"\t A rövidprogramban {adatok.Count()} induló volt");

            //3. feladat:
            Console.WriteLine("3. feladat");
            foreach (var item in dontosok)
            {
                if (item.D_orszag=="HUN")
                {
                    Console.WriteLine($"\t A magyar versenyző bejutott a kűrbe");
                    break;
                }
                else
                {
                    Console.WriteLine($"\t A magyar versenyző nem jutott be a kűrbe");
                    break;
                }
            }

            //5. feladat:
            Console.WriteLine("5. feladat");
            Console.Write($"\t Kérem a versenyző nevét: ");
            string versenyzo_neve = Console.ReadLine();
            foreach (var i in adatok)
            {
                if (i.Nev == versenyzo_neve)
                {
                    Console.WriteLine("Volt ilyen nevű induló");
                }
                else
                {
                    Console.WriteLine("Ilyen nevű induló nem volt");
                    break;
                }
            }
        }
    }
}