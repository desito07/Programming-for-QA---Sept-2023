﻿using System.Net.Http.Headers;

namespace _05._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;

            for(int row = 1; row <= n; row++) {
                
                for(int col = 1; col <= row; col++) 
                {
                    Console.Write($"{counter} ");
                    counter++;

                    if(counter > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();

                if (counter > n)
                {
                    break;
                }
            }
        }
    }
}