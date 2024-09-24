using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxCalculator
{
    public static class TaxCalculator
    {
        private const decimal BasicTaxRate = 0.10m;
        private const decimal ImportDutyTaxRate = 0.05m;

        public static decimal CalculateTax(Item item)
        {
            decimal tax = 0m;

            if (!item.IsExempt)
            {
                tax += item.Price * BasicTaxRate;
            }
            if (item.IsImported)
            {
                tax += item.Price * ImportDutyTaxRate;
            }

            return RoundUpTaxValue(tax);
        }

        private static decimal RoundUpTaxValue(decimal tax)
        {
            return Math.Ceiling(tax * 20) / 20;
        }
    }

}
