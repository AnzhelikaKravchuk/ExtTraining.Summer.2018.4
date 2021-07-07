﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    /// <summary>
    /// Class with information about event.
    /// </summary>
    public class StockEventArgs : EventArgs
    {
        public int USD { get; set; }

        public int Euro { get; set; }
    }
}
