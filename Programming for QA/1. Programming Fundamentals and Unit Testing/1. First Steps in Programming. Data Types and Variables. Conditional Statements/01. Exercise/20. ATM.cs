﻿namespace _20._ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = int.Parse(Console.ReadLine());
            int withdraw = int.Parse(Console.ReadLine());
            int limit = int.Parse(Console.ReadLine());

            if(balance > withdraw && withdraw < limit)
            {
                Console.WriteLine("The withdraw was successful.");
            }
            else if(withdraw > balance && withdraw < limit)
            {
                Console.WriteLine("Insufficient availability.");
            }
            else if(withdraw > balance && withdraw > limit)
            {
                Console.WriteLine("The limit was exceeded.");
            }

        }
    }
}