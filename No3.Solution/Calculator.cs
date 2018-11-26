using No3.Solution.Interfaces;
using System;
using System.Collections.Generic;


// Интерфейсы и делегаты используются для расширения функциональности

namespace No3.Solution
{
    public class Calculator
    {
        public double CalculateAverage(List<double> values, IAverager averager)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return averager.Transform(values);
        }

        public double CalculateAverage(List<double> values, Func<List<double>, double> averager)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return averager(values);
        }
    }
}

