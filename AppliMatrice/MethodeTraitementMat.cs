using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AppliMatrice
{
    public struct MethodeTraitementMat
    {
        /// <summary>
        /// Génère une matrice contenant des valeurs 
        /// Hypothèse : ligne,colonne entre 0 et 20
        /// </summary>
        /// <param name="tableau"></param>
        /// <param name="ligne"></param>
        /// <param name="colonne"></param>
        public void RempliTabMat(out int[,] tableau, int ligne, int colonne)
        {
            Random alea = new Random();
            tableau = new int[ligne, colonne];
            for (int i = 0; i < ligne; i++)
            {
                for (int j = 0; j < colonne; j++)
                {
                    tableau[i, j] = alea.Next(0, 20);
                }
            }
        }
        /// <summary>
        /// Création d'une chaine de caractère contenant les valeurs d'une matrice séparée par des virgules
        /// </summary>
        /// <param name="tableau"></param>
        /// <param name="chaine"></param>
        public void ConcatTabMat(int[,] tableau, out string chaine)
        {
            chaine = "";
            for (int i = 0; i < tableau.GetLength(0); i++)
            {
                for (int j = 0; j < tableau.GetLength(1); j++)
                {
                    chaine += tableau[i, j] + ", ";
                }
                chaine += "\n";
            }
        }

        /// <summary>
        /// Additionne 2 matrices "tableau1,tableau2" générée par "RempliTabMat" et renvoi "tableau3" comme somme des deux et "resultat" pour savoir si l'addition est true ou false
        /// </summary>
        /// <param name="tableau1"></param>
        /// <param name="tableau2"></param>
        /// <param name="tableau3"></param>
        /// <param name="resultat"></param>
        public void AddTabMat(int[,] tableau1, int[,] tableau2, out int[,] tableau3, out bool resultat)
        {
            tableau3 = new int[tableau1.GetLength(0), tableau2.GetLength(0)];
            if (tableau1.GetLength(0) == tableau2.GetLength(0) && tableau1.GetLength(1) == tableau2.GetLength(1))
            {
                for (int i = 0; i < tableau1.GetLength(0) ; i++)
                {
                    for (int j = 0; j < tableau2.GetLength(1) ; j++)
                    {
                        tableau3[i, j] = tableau1[i, j] + tableau2[i, j];
                    }
                }
                resultat = true;
            }
            else
            {
                resultat = false;
            }
        }
        /// <summary>
        /// Multiplie 2 matrices "tableau1,tableau2" générée par "RempliTabMat" et renvoi "tableauMulti" comme produit des deux et "resultat" pour savoir si l'addition est true ou false
        /// </summary>
        /// <param name="tableau1"></param>
        /// <param name="tableau2"></param>
        /// <param name="tableauMulti"></param>
        /// <param name="resultat"></param>
        public void MultiTabMat(int[,] tableau1, int[,] tableau2, out int[,] tableauMulti, out bool resultat)
        {
            tableauMulti = new int [tableau1.GetLength(0), tableau2.GetLength(1)];
            if (tableau1.GetLength(1) == tableau2.GetLength(0))
            {
                resultat = true;
                for (int i = 0; i  < tableau1.GetLength(0); i ++)
                {
                    for (int j = 0; j < tableau2.GetLength(1); j++)
                    {
                        tableauMulti[i, j] = 0;
                        for (int k = 0; k < tableau1.GetLength(1); k++)
                        {
                            tableauMulti[i, j] += tableau1[i, k] * tableau2[k, j];
                        }
                    }
                }
            }
            else
            {
                 resultat = false;
            }
        }
        /// <summary>
        /// vérification et empêche l'utilisateur d'entrer une valeur string.
        /// </summary>
        /// <param name="question">demande à adresser à l'utilisateur</param>
        /// <param name="n">nombre entier récupéré</param>
        public void LireReel(string question, out int n)
        {
            string nUser;
            Console.Write(question);
            nUser = Console.ReadLine();
            while (!int.TryParse(nUser, out n))
            {

                Console.WriteLine("Attention ! vous devez taper un nombre réel !");
                nUser = Console.ReadLine();
            }
        }



    }

}
