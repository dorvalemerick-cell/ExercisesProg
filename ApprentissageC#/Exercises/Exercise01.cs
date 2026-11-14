using System;

namespace Exercise01 {

    class Program {

        static void Main(string[] args)
        {
            while (DemanderNom() != "Q" && DemanderAge() != 0)
            {
                Console.WriteLine($"Bonjour {DemanderNom()} vous avez {DemanderAge()} ans");
            }
        }

        private static string DemanderNom()
        {
            // DEMANDER Nom
            Console.Write("Entrez votre nom(Q pour quitter): ");
            string? sNom = Console.ReadLine();
            return sNom!;
        }

        private static int DemanderAge()
        {
            int iAge = 0;
            // DEMANDER Age
            for (;;)
            {
                Console.Write("Entrez votre age (0 pour quitter): ");
                bool bValide = int.TryParse(Console.ReadLine(), out iAge);
                if (bValide)
                    break;
                Console.WriteLine($"{iAge} n'est pas un age valide!");
            }
            return iAge;
        }
    }
}
