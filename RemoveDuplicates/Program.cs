﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            DuplicateRemover remover = new DuplicateRemover();
            int newLength = remover.RemoveDuplicates(new int[] { 1, 1, 2 });
            Console.WriteLine("The new length is: " + newLength);
        }
    }
}
