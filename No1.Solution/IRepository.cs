﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public interface IRepository
    {
        IEnumerable<Tuple<bool, string>> Add(string password);

        IEnumerable<Tuple<bool, string>> Add(string password, IEnumerable<IPasswordChecker> checkers);
    }
}
