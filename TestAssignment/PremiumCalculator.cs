using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAssignment.Models;
using TestAssignment.PricingModels.Core;
using TestAssignment.ProratingMethods;

namespace TestAssignment
{
    internal class PremiumCalculator
    {
        private readonly IPricingModel _pricingModel;
        private readonly IProratingMethod _proratingMethod;

        public PremiumCalculator(IPricingModel pricingModel, IProratingMethod proratingMethod)
        {
            _pricingModel = pricingModel;
            _proratingMethod = proratingMethod;
        }

        public (decimal FullPremium, decimal ProratedPremium) CalculatePremium(Employee employee, DateOnly policyEndDate)
        {
            decimal fullPremium = _pricingModel.GetRateForYear(employee);
            decimal proratedPremium = _proratingMethod.CalculateProratedPremium(fullPremium, employee, policyEndDate);
            return (fullPremium, proratedPremium);
        }
    }
}
