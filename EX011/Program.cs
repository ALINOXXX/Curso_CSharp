﻿namespace EX011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================");
            Console.WriteLine("Contagem Regressiva");
            Console.WriteLine("===================");
            for (int i = 0; i < 10; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
