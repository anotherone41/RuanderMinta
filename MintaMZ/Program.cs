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
        static void Main(string[] args)
        {
            //fájlbeolvasás
            
            string[] sorok =File.ReadAllLines("forras.csv");

            //adatok száma
            int N = sorok.Length; // ha van fejléc akkor -1


        }
    }
}
