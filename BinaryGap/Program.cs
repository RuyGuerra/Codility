﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "";
            while (input != "exit")
            {
                Console.Write("input: ");
                input = Console.ReadLine();
                Console.WriteLine(Solution.solution(int.Parse(input)));
            }


        }
    }
}
