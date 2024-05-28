using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignment.Utils
{
    internal class AgeCalculator : IAgeCalculator
    {
        public int GetAge(DateOnly date)
        {
            var today = DateOnly.FromDateTime(DateTime.UtcNow);
            int age = today.Year - date.Year;

            if (date > today.AddYears(-age))
            {
                age--;
            };

            return age;
        }
    }
}
