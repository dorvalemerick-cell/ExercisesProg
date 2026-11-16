using System;
using System.Runtime.InteropServices;

namespace Exercise02
{
    class Program
    {
        static string? sReponse = "";
        static int iNombre = 0;

        static void Main(string[] args)
        {
            DemanderNombre();
            TraiterNombre();
        }

        private static void DemanderNombre()
        {
            Console.Write("Entrez un nombre: ");
            sReponse = Console.ReadLine();
            bool bValide = int.TryParse(sReponse, out iNombre);

        }

        private static void TraiterNombre()
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.Write($"{iNombre * i} ");
            }
        }
    }
}
