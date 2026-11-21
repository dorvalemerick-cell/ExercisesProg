using System.Net.Http.Headers;

namespace JeuPendu
{
    internal class Program
    {
        const string NOM_FICHIER_MOT = "mot";
        const int MAX_MOT_CHARGER = 100;
        static string? sMotTirer = "";

        static void Main(string[] args)
        {


            /* ###### TRAITEMENT DES MOTS ###### */
            string[] asListeMots = new string[MAX_MOT_CHARGER];
            ChargerFichierMot(asListeMots);
            TirerMot(asListeMots);
            /* ###### TRAITEMENT DES MOTS ###### */

            /* CACHER LE MOT */
            char[] acMotCacher = new char[sMotTirer!.Length];
            CacherMot(acMotCacher);

            string? sBanqueLettres = "abcdefghijklmnopqrstuvwxyz";
            string? sLettreSaisie = "";

            /* #################### MAIN GAME LOOP #################### */
            for (; ; )
            {
                /* ###### MONTRER DONNÉES ###### */
                Console.WriteLine(sMotTirer);
                Console.WriteLine($"Mot a trouver: {new string(acMotCacher)}");
                Console.WriteLine($"Lettres restantes: {sBanqueLettres}");
                Console.WriteLine($"Lettres saisie: {sLettreSaisie}");
                /* ###### MONTRER DONNÉES ###### */

                /* ###### DEMANDER SAISIE ###### */
                Console.Write("Entrer une lettre: ");
                string? sLettre = Console.ReadLine();

                /* ##### TRAITER LES DONNÉES MONTRER ##### */
                sBanqueLettres = sBanqueLettres.Replace(sLettre!, "_");
                sLettreSaisie += sLettre;

                ValiderLettre();
            }
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
        }

        public static void ValiderLettre()
        {
            // Valider une lettre qu l'utilisateur a saisie
            for (int i = 0; i <= sMotTirer.Length; i++)
            {

            }

        }
        public static void CacherMot(char[] p_acMotCacher)
        {
            for (int i = 0; i <= p_acMotCacher.Length - 1; i++)
            {
                p_acMotCacher[i] = '_';
            }
        }
    }
}
