using System;
using System.Linq;
using System.Net;

namespace Arrays3
{

    /*
     inca lucrez
     */

    class Program
    {
        static void Main(string[] args)
        {
            string[] greenTeam = new string[3];
            string[] redTeam = new string[3];

            for (int i = 0; i < greenTeam.Length; i++)
            {
                greenTeam[i] = Console.ReadLine();
            }

            for (int i = 0; i < redTeam.Length; i++)
            {
                redTeam[i] = Console.ReadLine();
            }

            string bothTeams = redTeam.Concat(greenTeam).ToArray().ToString();

            string requestName = Console.ReadLine();

            Console.WriteLine(requestName);

            Console.WriteLine(bothTeams);

            Console.WriteLine(bothTeams.Contains(requestName));

            if (bothTeams.Contains(requestName))
            {

                for (int i = 0; i < greenTeam.Length; i++)
                {

                    if (requestName == greenTeam[i])
                    {
                        Console.WriteLine("echipa verde");
                    }
                }

                for (int i = 0; i < redTeam.Length; i++)
                {

                    if (requestName == redTeam[i])
                    {
                        Console.WriteLine("echipa rosie");
                    }
                }
            }
            else
            {
                Console.WriteLine("N/A");
            }

            /*            for (int i = 0; i < redTeam.Length; i++)
                        {
                            if (requestName == greenTeam[i])
                            {
                                Console.WriteLine("echipa verde");
                            }
                            else if (requestName == redTeam[i])
                            {
                                Console.WriteLine("echipa rosie");)
                            }
                      *//*       else 
                            {
                               continue;
                            }*//*
                         break;
                         }

                Console.Write ("no")*/




        }
    }
}