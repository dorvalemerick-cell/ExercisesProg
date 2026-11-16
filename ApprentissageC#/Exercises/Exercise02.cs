using System;
using System.Runtime.InteropServices;

namespace Exercise02 {

    class Program
    {

        static void Main(string[] args)
        {
            for (; ; )
            {
                TraiterNombre(DemanderNombre());
            }

        }

        private static int DemanderNombre()
        {
            Console.Write("Entrez une nombre entier: ");
            bool bValide = int.TryParse(Console.ReadLine(), out int iNombre);
            if (bValide)
                return iNombre;
            else
                Console.WriteLine($"Saisie non valide");
            return iNombre;
        }

        private static void TraiterNombre(int p_iNombre)
        {
            if (p_iNombre == 0)
                Console.WriteLine($"{p_iNombre} est zero");
            switch (p_iNombre % 2)
            {
                case 0:
                    Console.WriteLine($"{p_iNombre} est un nombre pair");
                    break;
                case 1:
                case -1:
                    Console.WriteLine($"{p_iNombre} est un nombre impair");
                    break;
                default:
                    Console.WriteLine("Nombre non reconnu");
                    break;
            }

            if (p_iNombre >= 0)
                Console.WriteLine($"{p_iNombre} est un nombre positif");
            else
                Console.WriteLine($"{p_iNombre} est un nombre negatif");
        }
    }
}
