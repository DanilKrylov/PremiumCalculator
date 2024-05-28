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
    internal class AgeGenderRatedPricingModel : IPricingModel
    {
        private readonly IPricingModel _model;
        private readonly IAgeCalculator _ageCalculator;

        public AgeGenderRatedPricingModel(IAgeCalculator ageCalculator)
        {
            _ageCalculator = ageCalculator;

            var agePricingModel = new LinearAgePricingModel(ageCalculator);
            _model = new GenderMultiplyingPricingModel(
                agePricingModel,
                GetRateForMale,
                GetRateForFemale
            );
        }

        public decimal GetRateForYear(Employee employee)
        {
            return _model.GetRateForYear(employee);
        }

        private decimal GetRateForMale(Employee employee)
        {
            return 1;
        }

        private decimal GetRateForFemale(Employee employee)
        {
            var age = _ageCalculator.GetAge(employee.WorkStartDate);
            if(age <= 18)
            {
                return 1;
            }

            return 1.5m;
        }
    }
}
