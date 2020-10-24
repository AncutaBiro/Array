/*
Se dă un șir de 10 numere naturale. Afișează numerele din șir în ordine inversă.
Numerele din șir sunt date pe o singură linie și sunt despărțite între ele printr-un spațiu. 
Aplicația va afișa numerele tot pe o singură linie, despărțite printr-un spațiu între ele.
Exemplu:
Pentru datele de intrare:
1 2 3 4 5 6 7 8 9 10
La consolă se va afișa:
10 9 8 7 6 5 4 3 2 1
 */

using System;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputData = Console.ReadLine();

            string[] integerString = inputData.Split(" ");

            int[] integers = new int[integerString.Length];

            for (int i= 0; i < integers.Length; i++)
            {
                integers[i] = int.Parse(integerString[i]);
            }

            Array.Reverse(integers);

            string result = string.Join(" ", integers);

            Console.Write(result);

        }
    }
}
