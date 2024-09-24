using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxCalculator
{
    public class Item
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }
        public bool IsImported { get; private set; }
        public bool IsExempt { get; private set; }

        public Item(string name, decimal price, int quantity, bool isImported, bool isExempt)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            IsImported = isImported;
            IsExempt = isExempt;
        }

        public decimal CalculateTotalPrice(decimal taxRate)
        {
            decimal totalPrice = Price + taxRate;
            return totalPrice * Quantity;
        }
    }

}
