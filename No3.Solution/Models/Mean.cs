using No3.Solution.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution.Models
{
    public class Mean : IAverager
    {
        public double Transform(List<double> values)
        => values.Sum() / values.Count;
    }
}
