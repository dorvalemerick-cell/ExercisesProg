using System;
using System.Runtime.InteropServices;

namespace Exercise02
{

    class Program
    {

        static void Main(string[] args)
        {
            for (; ; )
            {
                if (LireInt("Entrez un nombre (Q pour quitter): ") == 9999)
                    break;
            }
        }


        private static void TraiterNombre()
        {

        }

        private static int LireInt(string p_sQuestion)
        {
            Console.Write(p_sQuestion);
            string? sReponse = Console.ReadLine();
            bool bValide = int.TryParse(sReponse, out int iNombre);
            if (bValide)
                return iNombre;
            else if (bValide == false && sReponse == "Q")
                return 9999;
            Console.WriteLine("Saisie non valide");
            return iNombre;
        }
    }
}
