/*
Se dă pe o linie o frază compusă din mai multe cuvinte despărțite între ele printr-unul sau mai multe spații. 
Să se scrie o aplicație consolă ce tipărește toate cuvintele din frază, câte unul pe linie.
Exemplu:
Pentru datele de intrare:
o   fraza de    test
La consolă se va afișa:
o
fraza
de
test
 */

using System;

namespace StringsProcessing5
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputString = Console.ReadLine();

         /*   string result = Regex.Replace(x, @"\s+", "\n").Trim();*/

            string result = String.Join("\n", inputString.Split(' ', StringSplitOptions.RemoveEmptyEntries));

            Console.WriteLine(result);

        }
    }
}

    
