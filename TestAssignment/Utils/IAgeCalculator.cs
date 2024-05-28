using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignment.Utils
{
    internal interface IAgeCalculator
    {
        public int GetAge(DateOnly date);
    }
}
