
namespace test
{
    internal class Program
    {
        static bool running = true;

        public static void Main(string[] args)
        {
            bool running = true;
            string? sSaisie = "";
            while  (running)
            {
                sSaisie = DemanderSaisie("Entrez une lettre: ");

                Console.WriteLine(sSaisie);

                if (sSaise == "o")
                {
                    MessageGagner("Bravo! Voulez vous recommencer (O/N)?: ");
                }
            }
        }

        public static string DemanderSaisie(string p_question)
        {

            string? sSaisie = "";
            do
            {
                Console.Write(p_question);
                sSaisie = Console.ReadLine();
            } while (string.IsNullOrEmpty(sSaisie));

            return sSaisie;
        }

        public static void MessageGagner(string p_message)
        {
            Console.WriteLine(p_message);
            string? sReponse = Console.ReadLine();

            if (sReponse = "O")
            {
                running = true;
            }
            else if (sReponse = "N")
            {
                running = false;
            }


        }
    }
}
