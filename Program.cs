using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5.ElevadoALa(3));
            Console.WriteLine(7.ElevadoALa(2));

            Console.WriteLine(5.Doble());

            Console.WriteLine("Documento con extensión: nameFile".AgregaExtensionDoc());

            Console.ReadLine();
        }
    }

    // Por buenas practicas se suele usar el tipo de dato y la palabra 'ExtensionMethods'
    public static class IntegerExtensionMethods
    {
        public static double ElevadoALa(this int valor, int exponente)
        {
            return Math.Pow(valor, exponente);
        }

        public static double Doble(this int valor)
        {
            return valor * 2;
        }
    }


    public static class StringExtensionMethods
    {
        public static string AgregaExtensionDoc(this string valor)
        {
            return valor + ".docx";
        }
    }
}
