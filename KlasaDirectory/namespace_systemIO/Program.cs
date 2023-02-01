using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace namespace_systemIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesite putenju datoteke");
            string putanja = Console.ReadLine();

            if(Directory.Exists(putanja))
            {
                foreach (string datoteke in Directory.GetFiles(putanja))
                {
                    Console.WriteLine(datoteke);
                }
            }

            string putanjaPoddirektorija=putanja.Insert(putanja.Length,"//TEST");
            if (!Directory.Exists(putanjaPoddirektorija))
            {
                Directory.CreateDirectory(putanjaPoddirektorija);
            }
            else
            {
                Console.WriteLine("Direktorij već postoji!");
            }
            Console.WriteLine("svi direktoriji");
            foreach(string direktorij in Directory.GetDirectories(putanja))
            {
                Console.WriteLine(direktorij);
            }

            Directory.Delete(putanjaPoddirektorija);
            Console.WriteLine("'TEST' je obrisan");
            foreach (string direktorij in Directory.GetDirectories(putanja))
            {
                Console.WriteLine(direktorij);
            }

            Console.ReadKey();
        }
    }
}
