using System;
using System.Transactions;

namespace Arrays7
{
    class Program
    {
        static void Main(string[] args)
        {

            int noStores = 2;

            int trimesters = 4;

            double[] doubleArray = new double [100];



            int[,] matrix = new int [noStores, trimesters];/*
*/
            while (noStores > 0)
            {
                
                string [] input = Console.ReadLine().Split();

/*                if (input != '\n')*/
                {
                    doubleArray = Array.ConvertAll(input, double.Parse);
                }

                foreach (double i in doubleArray)
                    Console.WriteLine(i);


              /*  string[] stringArray = input.ToString("F", input.Split(" "));

                for (int i = 0; i < stringArray.Length; i++)
                {
                    doubleArray[i] = Math.Round (Convert.ToDouble(stringArray[i]), 2);
                    Console.Write(doubleArray[i]);
                }
*/
                /* while (input != " " && char.Parse(input) != '\n')
                 {
                     for (int i = 0; i < input.Length; i++)
                     {
                         doubleArray [i] = Convert.ToDouble(input);
                     }
                 }

                 noStores--;
              }*/

            }


                
            /*            }*/

           /* foreach (int i in matrix)
            {
                foreach (int j in matrix) 
                { 

                Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine(" "); 
            }*/
            
           
        }
    }
}
