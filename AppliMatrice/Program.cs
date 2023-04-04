using System;

namespace AppliMatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] tableau1;
            int[,] tableau2;
            int[,] tableau3;
            bool resultat;
            int colonne;
            int ligne;
            string chaine;
            string choix;


            MethodeTraitementMat MesOutils = new MethodeTraitementMat();
            do // Boucle de reprise générale
            {
                Console.WriteLine("Calculs matriciels");


                Console.WriteLine("=========================");

                Console.WriteLine("Menu : " +

                "\n    1. Addition de matrice" +
                "\n    2. Multiplication de matrice");

                choix = Console.ReadLine();
                if (choix == "1")
                {
                    Console.WriteLine("Entrez les valeurs de la première matrice");
                    MesOutils.LireReel("Nombre de ligne : ", out ligne);
                    MesOutils.LireReel("Nombre de colonne : ", out colonne);
                    MesOutils.RempliTabMat(out tableau1, ligne, colonne);
                    Console.WriteLine("Entrez les valeurs de la deuxième matrice");
                    MesOutils.LireReel("Nombre de ligne : ", out ligne);
                    MesOutils.LireReel("Nombre de colonne : ", out colonne);
                    MesOutils.RempliTabMat(out tableau2, ligne, colonne);
                    MesOutils.AddTabMat(tableau1, tableau2, out tableau3, out resultat);
                    MesOutils.ConcatTabMat(tableau1, out chaine);
                    Console.WriteLine(chaine);
                    Console.WriteLine("=========================");
                    MesOutils.ConcatTabMat(tableau2, out chaine);
                    Console.WriteLine(chaine);
                    Console.WriteLine("=========================");
                    MesOutils.ConcatTabMat(tableau3, out chaine);
                    Console.WriteLine(chaine);
                }
                if (choix == "2")
                {
                    Console.WriteLine("Entrez les valeurs de la première matrice");
                    MesOutils.LireReel("Nombre de ligne : ", out ligne);
                    MesOutils.LireReel("Nombre de colonne : ", out colonne);
                    MesOutils.RempliTabMat(out tableau1, ligne, colonne);
                    Console.WriteLine("Entrez les valeurs de la deuxième matrice");
                    MesOutils.LireReel("Nombre de ligne : ", out ligne);
                    MesOutils.LireReel("Nombre de colonne : ", out colonne);
                    MesOutils.RempliTabMat(out tableau2, ligne, colonne);
                    MesOutils.MultiTabMat(tableau1, tableau2, out tableau3, out resultat);
                    MesOutils.ConcatTabMat(tableau1, out chaine);
                    Console.WriteLine(chaine);
                    Console.WriteLine("=========================");
                    MesOutils.ConcatTabMat(tableau2, out chaine);
                    Console.WriteLine(chaine);
                    Console.WriteLine("=========================");
                    MesOutils.ConcatTabMat(tableau3, out chaine);
                    Console.WriteLine(chaine);
                }
                /*MesOutils.RempliTabMat(out tableau, ligne, colonne);
                MesOutils.ConcatTabMat(tableau, out chaine, colonne, ligne);
                Console.WriteLine(chaine);*/


            } while (true);


        }
    }
    
}
