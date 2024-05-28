using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAssignment.Models;

namespace TestAssignment.PricingModels.Core
{
    internal class GenderMultiplyingPricingModel : MultiplyingPricingModel
    {
        private readonly Func<Employee, decimal> _getMultiplierForMale;
        private readonly Func<Employee, decimal> _getMultiplierForFemale;

        public GenderMultiplyingPricingModel(IPricingModel rootPricingModel, Func<Employee, decimal> getMultiplierForMale, Func<Employee, decimal> getMultiplierForFemale)
            : base(rootPricingModel)
        {
            _getMultiplierForMale = getMultiplierForMale;
            _getMultiplierForFemale = getMultiplierForFemale;
        }

        public override decimal GetMultiplier(Employee employee)
        {
            if (employee.Gender == Gender.Male)
            {
                return _getMultiplierForMale(employee);
            }

            if (employee.Gender == Gender.Female)
            {
                return _getMultiplierForFemale(employee);
            }

            throw new ArgumentException("Invalid gender.");
        }
    }
}
