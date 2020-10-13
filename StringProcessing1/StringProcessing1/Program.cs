
/*
Se dă un text pe o linie și o literă pe următoarea linie. Să se scrie o aplicație consolă ce determină dacă litera dată se află în text sau nu.
Exemplu:
Pentru datele de intrare:
sample text
a
La consolă se va afișa:
True*/

using System;

namespace StringProcessing1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();

            string ch = Console.ReadLine();

            Console.WriteLine(inputData.Contains(ch));
        }

    }
            
 }
        
    

