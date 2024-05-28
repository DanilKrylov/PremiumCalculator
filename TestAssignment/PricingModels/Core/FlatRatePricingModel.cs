using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAssignment.Models;

namespace TestAssignment.PricingModels.Core
{
    internal class FlatRatePricingModel : IPricingModel
    {
        private readonly decimal _fullPremium;

        public FlatRatePricingModel(decimal fullPremium)
        {
            if (fullPremium < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(fullPremium));
            }

            _fullPremium = fullPremium;
        }

        public decimal GetRateForYear(Employee employee)
        {
            return _fullPremium;
        }
    }
}
