/*
Un panagram e o frază care conține toate literele din alfabet (cele 26 de caractere ale alfabetului englezesc).
Scrie un program care determină dacă o frază e un panagram.
Exemplu:
Pentru datele de intrare:
The quick brown fox jumps over the lazy dog
La consolă se va afișa:
True
 */

using System;

namespace Arrays6
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            /*transform all the letters in lowercase*/
            string lowerCaseString = inputString.ToLowerInvariant();

            /*create a new string, using 2 loops and checking if the letter already exists, finally add only the leters that are unique*/
            string noDuplicates = "";

            for (int i = 0; i < lowerCaseString.Length; i++)
            {
                bool check = false;
                for (int j = 0; j < noDuplicates.Length; j++)
                {
                    if (lowerCaseString[i] == noDuplicates[j])
                    {
                        check = true;
                        break;
                    }
                }
                if (check == false)
                {
                    noDuplicates += lowerCaseString[i];
                }
            }

            /*transform the string in char array to Sort alphabetically and also group all the whitespaces at the beginning of the array*/
            char[] charString = noDuplicates.ToCharArray();
            
            Array.Sort(charString);

            /*reconvert to String and remove the whitespaces from the first positions*/
            string finalString = new string(charString).TrimStart();

            /*if the created string has the lenght of 26 means it has all the characters form the english alphabet */
            if (finalString.Length == 26)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        
            /*transform all the letters in lowercase*/
            /*       string lowerCaseString = inputString.ToLowerInvariant();*/

            /*using Linq create a new string Ordered Ascending from a to z, remove duplicates with Distrinct(), finally trim de whitespaces from the beginning of the sentence*/
            /*            string newString = new string(lowerCaseString.OrderBy(c => c).Distinct().ToArray()).TrimStart();*/

            /*if the created string has the lenght of 26 means it has all the characters form the english alphabet */
            /* if (newString.Length == 26) 
             {
                 Console.WriteLine("True");
             }
             else
             {
                 Console.WriteLine("False");
             }*/
        }
    }
}
