using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_di_dijkstraa
{
    class Program
    {
        static int[,] GeneraMatriceSpecchiataConZeroObliqui(int righe, int colonne)
        {
            Random rnd = new Random();
            int valoreCasuale = 0;
            int[,] matrice = new int[righe, colonne];

            for (int i = 0; i < righe; i++)
            {
                for (int j = 0; j < colonne / 2 + 1; j++)
                {
                    do
                    {
                        valoreCasuale = rnd.Next(-1, 11);
                    }
                    while (valoreCasuale == 0);
                    matrice[i, j] = valoreCasuale;
                    matrice[j, i] = valoreCasuale;
                }
                matrice[i, i] = 0;
            }
            return matrice;
        }
        public static void Main()
        {
            Console.WriteLine("Inserisci nodo di partenza");
            string NodoPartenza = Console.ReadLine();
            Console.WriteLine("Inserisci nodo di arrivo");
            string NodoArrivo = Console.ReadLine();
            Random random = new Random();
            int[,] matrice = GeneraMatriceSpecchiataConZeroObliqui(4, 4);
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    Console.Write(matrice[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("La distanza è ") ;
            if (NodoPartenza =="A")
            {
                
            }
            if (NodoPartenza == "B")
            {
                
            }
            if (NodoPartenza == "C")
            {
                
            }
            if (NodoPartenza == "D")
            { 
                
            }
        }

    }
}