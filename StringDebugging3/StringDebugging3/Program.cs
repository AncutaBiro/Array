/*
Să se scrie o aplicație consolă ce extrage numerele întregi dintr-o frază dată și le afișează pe toate pe o linie, despărțite printr-un spațiu.
Sugestie: Folosiți execuția pas cu pas pentru a localiza și fixa eroarea din proiectul atașat.

Exemplu:
Pentru datele de intrare:
4 ore pe zi, 5 zile pe saptamana
La consolă se va afișa:
4 5
 */

using System;

namespace NumbersExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string numbers = "";
            bool digitAdded = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= '0' && text[i] <= '9')
                {
                    numbers += text[i];

 /*                   digitAdded = !digitAdded;*/
/*                    because after checking the first numbers it becomes not True == false and never enters the else clause, so not adding space beetween the numbers*/

                    digitAdded = true;
                }
                else
                {
                    if (digitAdded)
                    {
                        numbers += " ";
                        digitAdded = false;
                    }
                }
                
            }
            Console.WriteLine(numbers);
            Console.ReadLine();
        }
    }
}

