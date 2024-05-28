using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAssignment.Models;

namespace TestAssignment.ProratingMethods
{
    internal class ProrateByMonthsMethod : IProratingMethod
    {
        public decimal CalculateProratedPremium(decimal fullPremium, Employee employee, DateOnly policyEndDate)
        {
            int monthsRemaining = (policyEndDate.Year - employee.WorkStartDate.Year) * 12 + policyEndDate.Month - employee.WorkStartDate.Month;
            return fullPremium / 12 * monthsRemaining;
        }
    }
}
