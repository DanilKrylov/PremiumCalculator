using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAssignment.Models;
using TestAssignment.PricingModels.Core;

namespace TestAssignment.PricingModels
{
    internal class DefaultFlatRatePricingModel : IPricingModel
    {
        private readonly FlatRatePricingModel _flatRatePricingModel;

        public DefaultFlatRatePricingModel()
        {
            _flatRatePricingModel = new FlatRatePricingModel(1000);
        }

        public decimal GetRateForYear(Employee employee)
        {
            return _flatRatePricingModel.GetRateForYear(employee);
        }
    }
}
