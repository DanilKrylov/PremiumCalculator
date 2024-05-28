using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAssignment.Models;

namespace TestAssignment.ProratingMethods
{
    internal interface IProratingMethod
    {
        decimal CalculateProratedPremium(decimal fullPremium, Employee employee, DateOnly policyEndDate);
    }
}
