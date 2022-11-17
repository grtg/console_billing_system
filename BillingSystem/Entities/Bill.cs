using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Entities
{
    internal class Bill
    {
        public int Id { get; set; }
        public List<int> Product { get; set; }
        public decimal TotalPrice { get; set; }

        public Bill(int id, List<int> product)
        {
            Id = id;
            Product = product;
        }

    }
}
