using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAssignment.Models;
using TestAssignment.PricingModels.Core;
using TestAssignment.Utils;

namespace TestAssignment.PricingModels
{
    internal class LinearAgePricingModel : IPricingModel
    {
        private readonly AgeRatedPricingModel _ageRatedPricingModel;

        public LinearAgePricingModel(IAgeCalculator ageCalculator)
        {
            _ageRatedPricingModel = new AgeRatedPricingModel(
                GetRageForAge,
                ageCalculator
            );
        }

        public decimal GetRateForYear(Employee employee)
        {
            return _ageRatedPricingModel.GetRateForYear(employee);
        }

        private decimal GetRageForAge(int age)
        {
            return (age / 10 + 1) * 100 * age;
        }
    }
}
