﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2
{
    public class ForeCastReport
    {
        public void Update(object sender, WeatherChangedEventArgs e)
            => Console.WriteLine("ForeCast");
    }
}
