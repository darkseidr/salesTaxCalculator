using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxCalculator
{
    public class Receipt
    {
        private readonly List<Item> _items;
        private decimal _totalTaxes;
        private decimal _totalCost;

        public Receipt()
        {
            _items = new List<Item>();
            _totalTaxes = 0m;
            _totalCost = 0m;
        }

        public void AddItem(Item item)
        {
            decimal itemTax = TaxCalculator.CalculateTax(item);
            decimal finalPrice = item.CalculateTotalPrice(itemTax);

            _totalTaxes += itemTax * item.Quantity;
            _totalCost += finalPrice;

            Console.WriteLine($"{item.Quantity} {item.Name}: {finalPrice:f2}");
        }

        public void PrintReceipt()
        {
            Console.WriteLine($"Sales Taxes: {_totalTaxes:f2}");
            Console.WriteLine($"Total: {_totalCost:f2}");
        }
    }

}
