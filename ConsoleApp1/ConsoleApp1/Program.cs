/*Se dă pe o linie o intrare dintr-un dicționar englez-român astfel:
<cuvânt în limba engelză>=<traducerea în limba română>
Să se scrie o aplicație consolă ce extrage și tipărește pe câte o linie cuvântul în limba engleză și traducerea în limba română.
Exemplu:
Pentru datele de intrare:
blue=albastru
La consolă se va afișa:
blue
albastru
 */

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            string result = inputString.Replace("=", "\n");

            Console.WriteLine(result);

        }
    }
}
