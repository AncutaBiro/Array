/*
Se citeste de la tastatura un sir de numere si se opreste cand se tasteaza x.
La final app sa se afiseze pe cate o linie nr pozitive din sir, daca nu exista sa se afiseze N/A.
 
 */

using System;
using System.Collections.Generic;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputString = Console.ReadLine();

            List <int> resultList = new List<int> () ;
            
            while (inputString != "x") {

            int n = Convert.ToInt32(inputString);
            if (n > 0 && n!=0)
                {
                    resultList.Add(n);
                }
             inputString = Console.ReadLine();
            }

            if (resultList.Count > 0)
            {
                foreach (int i in resultList)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                    Console.WriteLine("N/A");
            }
        }
    }
}
