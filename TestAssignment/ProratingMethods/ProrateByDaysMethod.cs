using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAssignment.Models;

namespace TestAssignment.ProratingMethods
{
    internal class ProrateByDaysMethod : IProratingMethod
    {
        public decimal CalculateProratedPremium(decimal fullPremium, Employee employee, DateOnly policyEndDate)
        {
            var endDateTime = policyEndDate.ToDateTime(TimeOnly.MinValue);
            var startDateTime = employee.WorkStartDate.ToDateTime(TimeOnly.MinValue);
            int daysRemaining = (endDateTime - startDateTime).Days;
            return fullPremium / 365 * daysRemaining;
        }
    }
}
