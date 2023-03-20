﻿using System;
using System.Collections.Generic;

namespace _06._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> setNames = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                setNames.Add(name);

            }

            foreach (var name in setNames)
            {
                Console.WriteLine(name);
            }

        }
    }
}
