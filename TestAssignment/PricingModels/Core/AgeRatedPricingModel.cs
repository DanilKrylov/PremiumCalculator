using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAssignment.Models;
using TestAssignment.Utils;

namespace TestAssignment.PricingModels.Core
{
    internal class AgeRatedPricingModel : IPricingModel
    {
        private readonly IAgeCalculator _ageCalculator;
        private readonly Func<int, decimal> _getRateForAge;

        public AgeRatedPricingModel(Func<int, decimal> getRateForAge, IAgeCalculator ageCalculator)
        {
            _getRateForAge = getRateForAge;
            _ageCalculator = ageCalculator;
        }


        public decimal GetRateForYear(Employee employee)
        {
            var age = _ageCalculator.GetAge(employee.WorkStartDate);
            return _getRateForAge(age);
        }
    }
}
