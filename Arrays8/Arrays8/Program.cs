/*
Un fermier are N livezi și în fiecare livadă are un număr de meri, peri și cireși.

Să se scrie o aplicație consolă ce primește ca date de intrare:
pe prima linie numărul de livezi N
apoi încă N linii, fiecare dintre ele conținând numărul de meri, peri și cireși pentru câte o livadă. Numerele sunt depărțite între ele printr-un spațiu.
Și tipărește:
numărul total de pomi fructiferi pentru fiecare livadă, câte o livadă pe linie, în formatul Livada 1: 120
numărul total de meri în formatul Meri: 50, iar pe următoarele linii la fel pentru peri și cireși
Exemplu:

Pentru datele de intrare:

2
2 1 6
3 1 8
La consolă se va afișa:

Livada 1: 9
Livada 2: 12
Meri: 5
Peri: 2
Ciresi: 14
 */

using System;

namespace Arrays8
{
    class Program
    {
            static void Main(string[] args)
            {
                int noOrchards = Convert.ToInt32(Console.ReadLine());
                string [] fruitCategory = {"Meri", "Peri", "Ciresi"};
                int noFruitCategories = fruitCategory.Length;

                int [,] matrix = new int [noOrchards, noFruitCategories];

                int [] sumOrchard = new int[noOrchards]; ;

                int [] totalFruitCatageory = new int [noFruitCategories];


                for (int i = 0; i < noOrchards; i++)
                {
                    String input = Console.ReadLine();
                    String[] inputs = input.Split(' ');

                    for (int j = 0; j < noFruitCategories; j++)
                    {
                        matrix[i, j] = Convert.ToInt32 (inputs[j]);
                    }
                }


            for (int i = 0; i < noOrchards; i++)
            {
                for (int j = 0; j < noFruitCategories; j++)

                {
                    sumOrchard [i] += matrix[i, j];
                }

                Console.WriteLine("Livada " + (i+1) + ": " + sumOrchard [i]);
            }


            for (int j = 0; j < noFruitCategories; j++)
            {
                for (int i = 0; i < noOrchards; i++)

                {
                    totalFruitCatageory [j] += matrix[i, j];
                }

                Console.WriteLine(fruitCategory[j] + ": " + totalFruitCatageory[j]);
            }
  
        }
    }
}



