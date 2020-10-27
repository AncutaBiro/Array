/*
Un grup de 6 elevi participă la un concurs de orientare turistică și se împart în două echipe egale: echipa verde și echipa rosie.
Să se scrie o aplicație consolă ce:
primește pe primele 3 linii numele elevilor din echipa verde
următoarele 3 linii conțin numele elevilor din echipa rosie
pe cea de-a șaptea linie se dă numele unui elev, iar aplicația trebuie să afișeze numele echipei din care face parte acesta sau N/A dacă numele nu a fost găsit în nici o echipă.
Exemplu:
Pentru datele de intrare:
Ion
George
Maria
Vasile
Elena
Andrea
Maria
La consolă se va afișa:
echipa verde
 */

using System;
using System.Collections.Generic;


namespace Arrays3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> teams = new List<string>();

            for (int i = 0; i < 6; i++)
            {
               teams.Add(Console.ReadLine());
            }

            string a = String.Join("", teams);

            string requestName = Console.ReadLine();

            if (a.Contains(requestName))
            {
                for (int i = 0; i < 3; i++)
                {
                    if (requestName == teams[i])
                    {
                        Console.WriteLine("echipa verde");
                    }
                }
                for (int i = 3; i < 6; i++)
                {
                    if (requestName == teams[i])
                    {
                        Console.WriteLine("echipa rosie");
                    }
                }
            }
            else
            {
                Console.WriteLine("N/A");
            }
        }
    }
}