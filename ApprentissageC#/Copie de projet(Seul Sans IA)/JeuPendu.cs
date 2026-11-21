namespace JeuPendu
{
    internal class Program
    {
        const string NOM_FICHIER_MOT = "mot";

        static string? sMotTirer = "";

        static void Main(string[] args)
        {
            int iMaxMotCharger = 50;
            string[] asListeMots = new string[iMaxMotCharger];


            ChargerFichierMot(asListeMots);
            TirerMot(asListeMots);
            Console.WriteLine(sMotTirer);
        }

        public static void ChargerFichierMot(string[] p_asListesMots)
        {
            int iCompteur = 0;
            string? sLigne = "";

            // Charge le fichier
            using StreamReader sr = new StreamReader(NOM_FICHIER_MOT)!;
            // Continue si la ligne n'est pas vide (null)
            while ((sLigne = sr.ReadLine()) != null)
            {
                // Ajoute le mot de chaque ligne a l'interieur de l'array
                p_asListesMots[iCompteur] = sLigne;
                iCompteur++;
            }
        }

        public static void TirerMot(string[] p_asListe)
        {
            // Prendre et charger un mot aleatoire du fichier mot qu'on a telecharger

            Random? rnd = new Random()!;
            int iIndexAleatoire;

            // Piger un autre index si la valeur associer a l'index est null ou vide
            do
            {
                iIndexAleatoire = rnd.Next(p_asListe.Length);
                sMotTirer = p_asListe[iIndexAleatoire];
            } while (string.IsNullOrEmpty(p_asListe[iIndexAleatoire]));

            Console.WriteLine(iIndexAleatoire);
        }

        public static void ValiderLettre()
        {
            // Valider une lettre qu l'utilisateur a saisie

        }
    }
}
