﻿namespace _24._Product_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            if(n1 == 0 || n2 == 0 || n3 == 0)
            {
                Console.WriteLine("zero");            
            }
            else if(n1 > 0 && n2 > 0 && n3 > 0)
            {
                Console.WriteLine("positive");
            }
            else if(n1 > 0 && n2 > 0 && n3 < 0)
            {
                Console.WriteLine("negative");
            }
            else if( n1 > 0 && n2 < 0 && n3 > 0)
            {
                Console.WriteLine("negative");
            }
            else if(n1 > 0 && n2 < 0 && n3 < 0)
            {
                Console.WriteLine("positive");
            }
            else if(n1 < 0 && n2 > 2 && n3 > 0)
            {
                Console.WriteLine("negative");
            }
            else if(n1 < 0 && n2 > 0 && n3 < 0)
            {
                Console.WriteLine("positive");
            }
            else if(n1 < 0 && n2 < 0 && n3 > 0)
            {
                Console.WriteLine("positive");
            }
            else if(n1 < 0 && n2 < 0 && n3 < 0)
            {
                Console.WriteLine("negative");
            }


        }
    }
}