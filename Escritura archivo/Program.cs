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
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            sw.Write(nombre);
            sw.Close();
            Console.WriteLine("Escribiendo");
            Console.ReadLine();
        }
    }
}
