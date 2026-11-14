using System;

namespace Exercise01 {

    class Program {

        static void Main(string[] args)
        {
            for (;;)
            {
                DemanderNom();
                // Console.ReadLine(DemanderAge());

            }
        }

        private static string DemanderNom()
        {
            Console.Write("Entrez votre nom: ");
            string? sNom = Console.ReadLine();
            return sNom!;
        }
    }
}
