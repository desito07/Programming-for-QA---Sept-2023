﻿namespace _21._Biggest_of_Five_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3 && n1 > n4 && n1 > n5)
            {
                Console.WriteLine(n1);
            }
            else if (n2 > n1 && n2 > n3 && n2 > n4 && n2 > n5)
            {
                Console.WriteLine(n2);
            }
            else if (n3 > n1 && n3 > n2 && n3 > n4 && n3 > n5)
            {
                Console.WriteLine(n3);
            }
            else if (n4 > n1 && n4 > n2 && n4 > n3 && n4 > n5)
            {
                Console.WriteLine(n4);
            }
            else if (n5 > n1 && n5 > n2 && n5 > n3 && n5 > n4)
            {
                Console.WriteLine(n5);
            }
        }
    }
}