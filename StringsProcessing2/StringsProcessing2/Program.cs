/*
Se dă un text pe o linie și o literă pe următoarea linie. 
Să se scrie o aplicație consolă ce determină numărul de apariții al literei date în text.
Exemplu:
Pentru datele de intrare:
sample text
t
La consolă se va afișa:
2
 */

using System;

namespace StringsProcessing2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            string ch = Console.ReadLine();

            int count = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i].ToString().Equals(ch))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
