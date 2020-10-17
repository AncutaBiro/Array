
/*
 Se dă pe o linie o frază compusă din mai multe cuvinte despărțite între ele printr-un singur spațiu. Pe următoarea linie se dă un număr X.
Să se scrie o aplicație consolă ce tipărește al X-lea cuvânt din frază, dacă fraza are cel puțin X cuvinte. Dacă fraza nu are X cuvinte, atunci tipărește N/A.

Exemplu:
Pentru datele de intrare:
o fraza de test
3
La consolă se va afișa:
de
 */

using System;

namespace StringsProcessing4
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputString = Console.ReadLine();

            string inputString2 = Console.ReadLine();
            int wordsPosition = Convert.ToInt32(inputString2);

            string[] result = inputString.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (wordsPosition < result.Length + 1 && wordsPosition > 0)
            {
                Console.WriteLine(result[wordsPosition - 1]);
            }
            else
            {
                Console.WriteLine("N/A");
            }

            }

        }

    }


