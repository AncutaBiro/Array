/*
Un comerciant are într-un oraș un lanț de N magazine.
Să se scrie o aplicație consolă ce primește ca date de intrare:
pe prima linie numărul de magazine N
apoi încă N linii, fiecare dintre ele conținând profitul pe cele 4 trimestre anului, cu două zecimale precizie, pentru câte un magazin. Numerele sunt depărțite între ele printr-un spațiu.
Și tipărește:

cel mai profitabil trimestru, în formatul Trimestrul 2: 5231.82
cel mai profitabil magazin, in formatul Magazinul 1: 765.20
Exemplu:

Pentru datele de intrare:
2
1000.50 2000.00 1000.00 3000.00
500.00 600.00 700.00 800.00

La consolă se va afișa:

Trimestrul 4: 3800.00
Magazinul 1: 7000.50
 
 */


using System;

namespace Arrays7
{
    class Program
    {
        static void Main(string[] args)
        {
            int noStores = Convert.ToInt32(Console.ReadLine());
            const int trimesters = 4;

            double[,] matrix = new double[noStores, trimesters];

            double[] sumTrimester = new double[trimesters];
            string maxSumTrimester;

            double[] sumStore = new double[noStores];
            string maxSumStore;


            for (int i = 0; i < noStores; i++)
            {
                String input = Console.ReadLine();
                String[] inputs = input.Split(' ');

                for (int j = 0; j < trimesters; j++)
                {
                    matrix[i, j] = Convert.ToDouble(inputs[j]);
                }
            }


            for (int j = 0; j < trimesters; j++)
            {
                for (int i = 0; i < noStores; i++)

                {
                    sumTrimester[j] += Math.Round (matrix[i, j], 2);
                }
            }
             maxSumTrimester = string.Format("{0:0.00}", max(sumTrimester));
             int p1 = positionMax (sumTrimester);

             Console.WriteLine("Trimestrul " + p1 + ": " + maxSumTrimester);


            for (int i = 0; i < noStores; i++)
            {
                for (int j = 0; j < trimesters; j++)

                {
                    sumStore [i] += Math.Round(matrix[i, j], 2);
                }
            }
            maxSumStore = string.Format("{0:0.00}", max(sumStore));
            int p2 = positionMax (sumStore);

            Console.WriteLine("Magazinul " + p2 + ": " + maxSumStore);

        }


        private static double max (double[] dArray)
            {
                double max = dArray[0];

                for (int i = 0; i < dArray.Length; i++)
                {
                    if (dArray[i] > max)
                    {
                        max = dArray[i];
                    }
                }

                return max;
        }

        private static int positionMax (double[] dArray)
        {
            double max = dArray[0];

            for (int i = 0; i < dArray.Length; i++)
            {
                if (dArray[i] > max)
                {
                    max = dArray[i];
                }
            }
            return Array.IndexOf(dArray, max) + 1;
        }

    }
}

