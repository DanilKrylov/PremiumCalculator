using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAssignment.Models;

namespace TestAssignment.PricingModels.Core
{
    internal abstract class MultiplyingPricingModel : IPricingModel
    {
        private readonly IPricingModel _rootPricingModel;

        protected MultiplyingPricingModel(IPricingModel rootPricingModel)
        {
            _rootPricingModel = rootPricingModel;
        }

        public decimal GetRateForYear(Employee employee)
        {
            var rootRate = _rootPricingModel.GetRateForYear(employee);
            var multiplier = GetMultiplier(employee);
            var rate = multiplier * rootRate;

            return rate;
        }

        public abstract decimal GetMultiplier(Employee employee);
    }
}
