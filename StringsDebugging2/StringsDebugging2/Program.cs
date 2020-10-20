/*Să se scrie o aplicație consolă ce determină de câte ori apare o secvență de text într-o frază dată.

Sugestie: Folosiți execuția pas cu pas pentru a localiza și fixa eroarea din proiectul atașat.

Exemplu:

Pentru datele de intrare:

Ana are mere mari.
ar
La consolă se va afișa:

2*/

using System;

namespace StringsDebugging2
{
    class Program
    {

/*determina corect cand exista testul de cautat , eroare indexoutofbound cand nu corespunde textul deloc*/
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string textToFind = Console.ReadLine();

            int count = 0;

            for (int i = 0; i < text.Length - 1; i++)
            {
                bool match = true;

                for (int j = 0; j < textToFind.Length; j++)
                {
                    if (text[i + j] != textToFind[j])
                    {
                        match = false;
                    }
                    continue;
                }

                if (match)
                {
                    count++;
                }

            }

            Console.WriteLine(count);
            Console.Read();

        }
    }
}
