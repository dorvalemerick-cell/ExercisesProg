using System;
using System.Runtime.InteropServices;

namespace Exercise02
{
    class Program
    {
        static string? sReponse = "";
        static int iNombre = 0;
        static bool bValide;

        static void Main(string[] args)
        {
            for (; ; )
            {

                DemanderNombre();
                if (sReponse == "Q")
                    break;
                else if (!bValide)
                    Console.WriteLine("Saisie non valide");
                else
                    TraiterNombre();
            }
        }

        private static void DemanderNombre()
        {
            Console.Write("Entrez un nombre: ");
            sReponse = Console.ReadLine();
            bValide = int.TryParse(sReponse, out iNombre);

        }

        private static void TraiterNombre()
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{iNombre * i} ");
            }
        }
    }
}
