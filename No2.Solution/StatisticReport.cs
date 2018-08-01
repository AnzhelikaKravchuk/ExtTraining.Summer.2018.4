﻿using System;

namespace No2.Solution
{
    public class StatisticReport
    {
        public void Subscribe(WeatherData data)
        {
            data.Change += this.Update;
        }

        public void Unsubscribe(WeatherData data)
        {
            data.Change -= this.Update;
        }

        public void Update(object sender, EventArgs e) => Console.WriteLine("Statistic");
    }
}