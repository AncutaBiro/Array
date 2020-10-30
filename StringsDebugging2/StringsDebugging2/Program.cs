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
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string textToFind = Console.ReadLine();

            int count = 0;

            for (int i = 0; i <= text.Length - textToFind.Length; i++)
            {
                bool match = true;

                for (int j = 0; j < textToFind.Length; j++)
                {
                    if (text[i + j] != textToFind[j])
                    {
                        match = false;
                        break;
                    }

                }

                if (match)
                {
                    count++;
                }

            }

            Console.WriteLine(count);
            Console.Read();


        /* https://www.geeksforgeeks.org/frequency-substring-string/ */ 

            /*
             int M = pat.Length;        
                    int N = txt.Length;        
                    int res = 0;

                    /* A loop to slide pat[] one by one */
            /*            for (int i = 0; i <= N - M; i++)*/
            /*{*/
            /* For current index i, check for 
        pattern match */
            /*int j;
            for (j = 0; j < M; j++)
            {
                if (txt[i + j] != pat[j])
                {
                    break;
                }
            }
*/
            // if pat[0...M-1] = txt[i, i+1, ...i+M-1] 
            /* if (j == M)
             {
                 res++;
                 j = 0;
             }
         }*/
            /*            return res;*/
            /*       }*/


        }
    }
}
