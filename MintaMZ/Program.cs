using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MintaMZ
{
    class Program
    {
        class Auto
        {
            private int ertek;
            private string tipus;

        }
        static void Main(string[] args)
        {
            //fájlbeolvasás
            
            string[] sorok =File.ReadAllLines("forras.csv");
            List<Auto> autok = new List<Auto>();
            foreach (string sor in sorok.Skip(1))
            {
                autok.Add(new Auto());
            }
            //adatok száma
            int N = sorok.Length; // ha van fejléc akkor -1
                                  //legvalamilyenebb
            int mindINdex = 0, maxINdex = 0;
            for (int i = 0; i < N; i++)
            {
                if(autok[i].ertek > autok)
                {
                    maxINdex = i;
                }
            }
            //eldöntés I
            int i = 0;
            while(i <N && !(T)) { i++; } //T: mit vizsgálunk?
            bool van = i < N;
            //eldöntés 2
            i = 0;
            while(i <N && T) { i++; }
            bool mind = i >= N;

            //hány félevan, melyek ezek: hányféle érték van a listában
            // HashSet<>
            HashSet<int> ertekek = new HashSet<int>();
            foreach (Auto auto in autok)
            {
                ertekek.Add(auto.ertek);
            }
            // kiírás:
            foreach (int ertek in ertekek)
            {
                Console.WriteLine(ertek);
            }
            //Melyikből mennyi van
            //Dictionary<string,int>
            Dictionary<string, int> tipusDB = new Dictionary<string, int>();
            foreach (Auto auto in autok)
            {

                string kulcs = auto.tipus;
                if (tipusDB.ContainsKey(kulcs))
                {
                    tipusDB[kulcs]++;

                }
                else
                {
                    tipusDB.Add(kulcs, 1);
                }
            }
            //kiírás:
            foreach (var item in tipusDB)
            {
                Console.WriteLine($"{item.Key} típusból {item.Value} darab");
            }
            //fájlkiírás
            //ha egy stringben van:
            string fn = "statisztika.txt";
            string kimenet = "ezt írom ki, ez lesz a fájlban"
            File.WriteAllText(fn, kimenet);

            //ha string []
            string[] kiirandoSOrok = new string[3];
            File.WriteAllLines(fn, kiirandoSOrok);
        }
    }
}
