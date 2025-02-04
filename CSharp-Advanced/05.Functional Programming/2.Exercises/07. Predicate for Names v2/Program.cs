﻿using System;
using System.Linq;

namespace _07._Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split().Where(x => x.Length <= n).ToArray();

            names.ToList().ForEach(x => Console.WriteLine(string.Join("\r\n", x)));
        }
    }
}
