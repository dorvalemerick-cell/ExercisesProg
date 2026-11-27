
namespace JeuPendu
{

    /// <summary>
    /// Auteur: Emerick Dorval
    /// Description: Faire un algoithme de jeux de bonhomme pendu. Une liste de mot doit etre charger d'un fichier texte.
    /// De cette liste, un mot doit etre piger au hasard et ce mot va etre le mot rechercher.
    /// Une banque de lettre doit retrecir apres chaque saisie, le mot choisi doit etre cacher par des underscores et, si
    /// la saisie est bonne, le decouvrir de petit a petit. A chaque erreurs, un membre sur le bonhomme doit apparaitre et si ils
    /// apparaissent tous, la partie est perdu. Il y a un compteur de victoire et de défaite.
    /// Date: 21-11-2026
    /// </summary>
    internal class Program
    {
        const string NOM_FICHIER_MOT = "mot";
        const int MAX_MOT_CHARGER = 100;

        static string? sMotTirer = "";
        static int iPartiesGagner = 0;
        static int iPartiesPerdu = 0;
        static int iErreurs = 0;
        static bool bPartieGagner = false;
        static bool bPartiePerdu = false;

        static void Main(string[] args)
        {
            bool bGameLoop = true;

            while (bGameLoop)
            {
                // Settez les valeurs par défault
                bPartieGagner = false;
                bPartiePerdu = false;
                iErreurs = 0;

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
                    Console.WriteLine($"Jeu pendu:\tGagnées: {iPartiesGagner}  Perdus: {iPartiesPerdu}");
                    DessinerPendu();
                    Console.WriteLine(sMotTirer);
                    Console.WriteLine($"Mot a trouver: {new string(acMotCacher)}");
                    Console.WriteLine($"Lettres restantes: {sBanqueLettres}");
                    Console.WriteLine($"Lettres saisie: {sLettreSaisie}");
                    Console.WriteLine();

                    /* ###### MONTRER DONNÉES ###### */

                    /* ########## DEMANDER SAISIE ########## */
                    string? sLettre;

                    do
                    {
                        Console.Write("Entrer une lettre: ");
                        sLettre = Console.ReadLine()!;

                    } while (string.IsNullOrEmpty(sLettre));


                    /* ##### FONCTION QUITTAGE, SAISIE DE MOTS COMPLET ET TRAITEMENT DE SAISIE NORMALE (lettres) ##### */
                    string? sReponse = "";
                    if (sLettre == "QUITTER")
                    {
                        bGameLoop = false;
                        break;
                    }
                    /* ##### SAISIE DE MOTS COMPLETS ##### */
                    else if (sLettre == sMotTirer)
                    {
                        // On a une nouvelle partie de gagner
                        iPartiesGagner += 1;

                        /* ##### MESSAGE VICTOIRE ##### */
                        Console.Write("Bravo! Tu a trouver le mot, voulez vous recommencer la partie (O/N)?: ");
                        sReponse = Console.ReadLine()!.ToUpper();

                        /* ##### OPTIONS DE VICTOIRE ##### */
                        if (sReponse == "O")
                        {
                            Console.Clear();
                            break;
                        }
                        else if (sReponse == "N")
                        {
                            bGameLoop = false;
                            break;
                        }
                    }
                    // Check si la saisie est un mot qui n'est pas egal au mot tirer
                    else if (sLettre.Length > 1 && sLettre != sMotTirer)
                        // On a une nouvelle erreur
                        iErreurs += 1;
                    /* ##### SAISIE NORMALE ##### */
                    else
                    {
                        /* TRAITER LES DONNÉES MONTRÉES EN HAUT */
                        sBanqueLettres = sBanqueLettres.Replace(sLettre!, "_");
                        sLettreSaisie += sLettre;

                        Console.Clear();
                        ValiderLettre(sLettre, acMotCacher);
                    }

                    // Check si notre nombre d'erreur dépasse la limite. Si oui on a perdu la partie et nos erreurs reset
                    if (iErreurs >= 6)
                    {
                        bPartiePerdu = true;
                        iPartiesPerdu += 1;
                        iErreurs = 0;
                    }

                    // Check si on a gagner la partie. Si oui, affiche le message et ces options
                    if (bPartieGagner)
                    {
                        /* ##### MESSAGE VICTOIRE ##### */
                        Console.Write("Bravo! Tu a trouver le mot, voulez vous recommencer la partie (O/N)?: ");
                        sReponse = Console.ReadLine()!.ToUpper();

                        /* ##### OPTIONS VICTOIRE ##### */
                        if (sReponse == "O")
                        {
                            Console.Clear();
                            break;
                        }
                        else if (sReponse == "N")
                        {
                            bGameLoop = false;
                            break;
                        }

                    }
                    // Check si la partie est perdu. Si oui, afficher son messsage et ces options
                    else if (bPartiePerdu)
                    {
                        /* ##### MESSAGE DEFAITE ##### */
                        Console.Write("Oh non! Partie terminer, voulez vous recomencer la partie(O/N)?: ");
                        sReponse = Console.ReadLine()!.ToUpper();

                        /* ##### OPTIONS DE DEFAITE ##### */
                        if (sReponse == "O")
                        {
                            Console.Clear();
                            break;
                        }
                        else if (sReponse == "N")
                        {
                            bGameLoop = false;
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Description: Télécharge le contenu du fichier texte et store le dans un tableau.
        /// </summary>
        /// <param name="p_asListesMots">Représente la liste dans laquelle ont store les mots télécharger</param>
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


        /// <summary>
        /// Description: Tire un mot de la banque de mot au hasard
        /// </summary>
        /// <param name="p_asListe">Représente la le tableau dans laquelle on a les mots</param>
        public static void TirerMot(string[] p_asListe)
        {
            // Prendre et charger un mot aleatoire du fichier mot qu'on a telecharger

            Random? rnd = new Random()!;
            int iIndexAleatoire;

            // Piger un autre index si la valeur associer a l'index precedent est null ou vide
            do
            {
                iIndexAleatoire = rnd.Next(p_asListe.Length);
                sMotTirer = p_asListe[iIndexAleatoire];
            } while (string.IsNullOrEmpty(p_asListe[iIndexAleatoire]));
        }



        /// <summary>
        /// Description: Valide la saisie
        /// </summary>
        /// <param name="p_Saisie">Représente la saisie par l'utilisateur</param>
        /// <param name="p_MotCacher">Représente la variable dans laquelle est le mot cacher</param>
        public static void ValiderLettre(string p_Saisie, char[] p_MotCacher)
        {

            // Check si la saisie est vide et redemander la saisie si oui
            if (string.IsNullOrEmpty(p_Saisie) || p_Saisie.Length != 1)
            {
                Console.WriteLine("Saisir qu'une lettre svp");
            }

            // ##### CONCERTI LA SAISIE EN MINUSCULE #####
            char cLettre = char.ToLower(p_Saisie[0]);
            bool bTrouver = false;

            // Parcour tout le mot, check si la saisie en minuscule est egal a l'indice en minuscule
            // *Convertire le mot et la saisie en minuscule pour faciliter la comparaison*
            for (int i = 0; i < sMotTirer!.Length!; i++)
            {
                if (char.ToLower(sMotTirer[i]) == cLettre)
                {
                    // L'underscore a la position i est egal a la/les valeurs associer a/au l'index i dans le mot piger au hassard dans ChargerMot()
                    // (Ex: mot: bob, motc: _ _ _, saisie: 'o', index saisie: 1, motc a l'index 1 est egal a mot a l'index 1 = _ o _)
                    p_MotCacher[i] = sMotTirer[i];
                    bTrouver = true;
                }
            }

            // Si pas la bonne lettre ajoute une erreur
            if (!bTrouver)
                iErreurs += 1;

            // Construi un string avec les valeurs du tableau MotCacher et check si le tout est egal au mot tirer
            // Si oui, la partie est gagner, ajoute 1 au compteur de parties gagner
            // (fct new string: char[] char = {'a', 'b', 'c'}. new string(char) = "abc") (colle les valeurs ensemble pour former un 'nouveau' string)
            if ((new string(p_MotCacher)) == sMotTirer)
            {
                bPartieGagner = true;
                iPartiesGagner += 1;
            }
        }

        /// <summary>
        /// Desctiption: Cacher le mot tirer au hasard
        /// </summary>
        /// <param name="p_acMotCacher"> Représente le tableau dans laquelle on va storer les underscores</param>
        public static void CacherMot(char[] p_acMotCacher)
        {
            // Ajoute un '_' pour chaque lettres du mot tirer (ex: ecrire 4 '_' si le mot a 4 lettres)
            for (int i = 0; i <= p_acMotCacher.Length - 1; i++)
            {
                p_acMotCacher[i] = '_';
            }
        }

        /// <summary>
        /// Description: La logique et le dessinage du bonhomme
        /// </summary>
        public static void DessinerPendu()
        {
            // fct if ternaire:   condition ? valeurOui : valeurNon
            char cTete = iErreurs >= 1 ? 'O' : ' ';
            char cCorp = iErreurs >= 2 ? '|' : ' ';
            char cBrasG = iErreurs >= 3 ? '/' : ' ';
            char cBrasD = iErreurs >= 4 ? '\\' : ' ';
            char cJambeG = iErreurs >= 5 ? '/' : ' ';
            char cJambeD = iErreurs >= 6 ? '\\' : ' ';

            // Dessiner le bonhomme
            Console.WriteLine($"-------------");
            Console.WriteLine($"|           |");
            Console.WriteLine($"|           |");
            Console.WriteLine($"|           {cTete}");
            Console.WriteLine($"|          {cBrasG}{cCorp}{cBrasD}");
            Console.WriteLine($"|          {cJambeG}{cJambeD}");
            Console.WriteLine($"|");
            Console.WriteLine($"============");
        }
    }
}
