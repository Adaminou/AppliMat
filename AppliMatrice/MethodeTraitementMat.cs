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
                    tableau[i, j] = alea.Next(0, 20);
                }
            }
        }

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
