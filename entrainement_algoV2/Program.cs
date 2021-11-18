using System;

namespace entrainement_algoV2
{
    class Program
    {
        public static string[] classeJoueur = new string[] { "Soutien", "Dps", "Soigneur" };
        public static int[] santeJoueur = new int[] { 150, 90, 110 };
        public static int[] attaqueJoueur = new int[] { 20, 40, 30 };

        public static int hpJoueur;
        public static int attkJoueur;
        public static int santeMonstre = 500;
        public static int attaqueMonstre = 40;
        static int potion = 20;

        static string DemanderLePrenomDuJoueur()
        {
            Console.WriteLine("Quel est votre doux pseudo ?");

            string reponse = Console.ReadLine();

            Console.WriteLine("Votre pseudo est {0}", reponse); // {0} insérer le premier paramètre qui suit

            return reponse;
        }

        static string DemanderLaClasseDuJoueur() // un index est un type int
        {

            Console.WriteLine("Veuillez choisir votre classe entre : Soutien, Dps ou Soigneur.");

            // while = la saisie doit être dans le while, tant que true, continue à boucler, sort quand c'est false
            bool reponseJoueur = true;

            string reponse = null;
            hpJoueur = 0;
            attkJoueur = 0;


            while (reponseJoueur)
            {
                reponse = Console.ReadLine();

                if (reponse == classeJoueur[0])
                {
                    Console.WriteLine("Vous êtes un : " + classeJoueur[0]);
                    Console.WriteLine("Votre personnage a :" + santeJoueur[0] + "HP et " + attaqueJoueur[0] + " d'attaque");
                    hpJoueur = santeJoueur[0];
                    attkJoueur = attaqueJoueur[0];
                    reponseJoueur = false;
                }
                else if (reponse == classeJoueur[1])
                {
                    Console.WriteLine("Vous êtes un : " + classeJoueur[1]);
                    Console.WriteLine("Votre personnage a :" + santeJoueur[1] + "HP et " + attaqueJoueur[1] + " d'attaque");
                    hpJoueur = santeJoueur[1];
                    attkJoueur = attaqueJoueur[1];
                    reponseJoueur = false;
                }
                else if (reponse == classeJoueur[2])
                {
                    Console.WriteLine("Vous êtes un : " + classeJoueur[2]);
                    Console.WriteLine("Votre personnage a :" + santeJoueur[2] + "HP et " + attaqueJoueur[2] + " d'attaque");
                    hpJoueur = santeJoueur[2];
                    attkJoueur = attaqueJoueur[2];
                    reponseJoueur = false;
                }
                else
                {
                    Console.WriteLine("Veuillez choisir parmi les 3 classes proposées !");
                }
            }
            return reponse;
        }

        static int JoueurQuiAttaque()
        {
            Console.WriteLine("Devant vous se dresse un monstre qui a " + santeMonstre + "PV");

            santeMonstre -= attkJoueur; // attention aux variables globales !

            Console.WriteLine("Vous infligez :" + attkJoueur + " au méchant. Il lui reste " + santeMonstre + "points de vie");
            return santeMonstre;
        }

        static int MonstreQuiAttaque()
        {
            Console.WriteLine("Vous avez " + hpJoueur + "PV");

            hpJoueur -= attaqueMonstre;

            Console.WriteLine("Le monstre vous inflige :" + attaqueMonstre + " au méchant. Il vous reste " + hpJoueur + "points de vie");
            return hpJoueur;
        }

        static int BoirePotionVie()
        {
            Console.WriteLine("Vous prenez une potion qui vous donne " + potion);
            hpJoueur += potion;
            Console.WriteLine("Il vous reste : " + hpJoueur + " de vie");
            return hpJoueur;
        }

        static bool EstFinDuJeu()
        {
            if ((santeMonstre > 0) && (hpJoueur > 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        static void Main(string[] args)
        {
            string prenomJoueur = DemanderLePrenomDuJoueur();
            string classeJoueur = DemanderLaClasseDuJoueur();

            Console.WriteLine("Vous avez choisi " + classeJoueur + "avec" + hpJoueur + "et" + attkJoueur);

            Console.WriteLine("Voulez vous ça ou ça");
            

            while (!EstFinDuJeu())
            {
                string choixUtilisateur = Console.ReadLine(); // pour récupérer la valeur toujours mettre dans une variable !!
                if (choixUtilisateur == "ATTAQUER")
                {
                    JoueurQuiAttaque();
                }
                else
                {
                    BoirePotionVie();
                }
                MonstreQuiAttaque();
            }
            Console.WriteLine("fini");
        }
    }
}
