using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Escritura_archivo
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            string[] Lines = {
                "Esto es la primera linea",
                "Esto es la segunda liena",
                "Esto es la tercera linea"
            };

            foreach (string Line in Lines)
            {
                sw.Write(Line);
            }
            sw.Close();
            Console.WriteLine("Escribiendo");
            Console.ReadLine();
        }
    }
}
