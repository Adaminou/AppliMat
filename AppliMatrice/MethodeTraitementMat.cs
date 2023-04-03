using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AppliMatrice
{
    public struct MethodeTraitementMat
    {
        public void RempliTabMat(out int[,] tableau, int ligne, int colonne)
        {
            Random alea = new Random();
            tableau = new int[ligne, colonne];
            for (int i = 0; i < ligne; i++)
            {
                for (int j = 0; j < colonne; j++)
                {
                    tableau[i, j] = alea.Next(ligne, colonne);
                }
            }
        }

        public void ConcatTabMat(int[,] tableau, out string chaine, int colonne, int ligne)
        {
            chaine = "";
            for (int i = 0; i < ligne; i++)
            {
                for (int j = 0; j < colonne; j++)
                {
                    chaine = chaine + tableau[i, j] + ", ";
                }
            }
        }

        public void AddTabMat(int[,] tableau1, int[,] tableau2,int [,]tableau3)
        {
            if (tableau1.GetLength(0) == tableau2.GetLength(0) && tableau1.GetLength(1) == tableau2.GetLength(1))
            {
                for (int i = 0; i < tableau1.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < tableau2.GetLength(0) - 1; j++)
                    {
                        tableau3[i, j] = tableau1[i, j] + tableau2[i, j];
                    }
                }
                bool resultat = true;
            }
            else
            {
                bool resultat = false;
            }
        }



    }

}
