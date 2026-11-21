using System.Net.Http.Headers;

namespace JeuPendu
{
    /* ##### A FAIRE ##### */
    // Implimenter les fonctions du bonhomme
    // Implimenter une fonction d'écriture de mot (gagner la partie si on écrit le bon mot)
    // Implimenter une fonction de  mots non valide (ajouter un membre si on a pas le bon mot)
    // Implimenter les fonctions de victoires (demander un choix quand on gange la partie O/N de si on veut continuer)
    // Implimenter une fonction de quittage (ecrire quitter)                                                             **IMPLIMENTER**
    //
    internal class Program
    {
        const string NOM_FICHIER_MOT = "mot";
        const int MAX_MOT_CHARGER = 100;

        static string? sMotTirer = "";
        static int iPartiesGagner = 0;
        static int iPartiesPerdu = 0;
        static int iErreurs = 0;

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
                Console.Clear();
                /* ###### MONTRER DONNÉES ###### */
                Console.WriteLine($"Jeu pendu:\tGagnées: {iPartiesGagner}  Perdus: {iPartiesPerdu}");
                Console.WriteLine(sMotTirer);
                Console.WriteLine($"Mot a trouver: {new string(acMotCacher)}");
                Console.WriteLine($"Lettres restantes: {sBanqueLettres}");
                Console.WriteLine($"Lettres saisie: {sLettreSaisie}");
                /* ###### MONTRER DONNÉES ###### */

                /* ###### DEMANDER SAISIE ###### */
                string sLettre;
                do
                {
                    Console.Write("Entrer une lettre: ");
                    sLettre = Console.ReadLine();
                } while (string.IsNullOrEmpty(sLettre));

                if (sLettre == sMotTirer)
                    iPartiesGagner += 1;
                else
                    Console.WriteLine("oops, un membre d'ajouter");

                /* ##### QUITTAGE ##### */
                if (sLettre == "QUITTER")
                    break;


                /* ##### TRAITER LES DONNÉES MONTRER ##### */
                sBanqueLettres = sBanqueLettres.Replace(sLettre!, "_");
                sLettreSaisie += sLettre;

                ValiderLettre(sLettre, acMotCacher);
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

        public static void ValiderLettre(string p_Saisie, char[] p_MotCacher)
        {
            if (string.IsNullOrEmpty(p_Saisie) || p_Saisie.Length != 1)
            {
                Console.WriteLine("Saisir qu'une lettre svp");
            }

            char cLettre = char.ToLower(p_Saisie[0]);
            bool bTrouver = false;

            for (int i = 0; i < sMotTirer.Length; i++)
            {
                if (char.ToLower(sMotTirer[i]) == cLettre)
                {
                    p_MotCacher[i] = sMotTirer[i];
                    bTrouver = true;
                }
            }

            if (!bTrouver)
            {
                Console.WriteLine("Oups, un membre d'ajouter");
                iErreurs += 1;
                if (iErreurs >= 6)
                {
                    iPartiesPerdu += 1;
                    iErreurs = 0;
                }
            }

            if ((new string(p_MotCacher)) == sMotTirer)
            {
                Console.WriteLine("Partie gagner");
                iPartiesGagner += 1;

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
