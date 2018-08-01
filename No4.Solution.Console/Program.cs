﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IRandomFileGenerator generator = new RandomBytesFileGenerator();
            generator.GenerateFiles(2,34);

            generator = new RandomCharsFileGenerator();
            generator.GenerateFiles(1, 53);
        }
    }
}
