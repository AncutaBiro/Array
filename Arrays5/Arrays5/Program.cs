/*
Mai sus avem un triunghi format din 4 nivele. Determină numărul total de puncte de intersecție într-un triunghi cu n nivele.
Exemplu:
Pentru datele de intrare:
4
La consolă se va afișa:
15
 */
using System;

namespace Arrays5
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputdata = Console.ReadLine();
            int n = Convert.ToInt32(inputdata);

            int sum = 0;

            for (int i = 0; i <= n; i++) 
            {
                sum += i + 1;
            }

            Console.WriteLine(sum);
        }
    }
}
