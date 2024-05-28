using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAssignment.Models;

namespace TestAssignment.PricingModels.Core
{
    internal interface IPricingModel
    {
        public decimal GetRateForYear(Employee employee);
    }
}
