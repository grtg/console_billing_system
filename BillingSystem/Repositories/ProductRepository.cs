using BillingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Repositories
{
internal class ProductRepository
{
    public List<Product> Products { get; private set; }
    public ProductRepository()
    {
        Products = new List<Product>();

            Products.Add(new Product(1, "1. Mussels or Clams Diablo", (decimal)16.50));
            Products.Add(new Product(2, "2. Gambas al Ajillo", (decimal)12.20));
            Products.Add(new Product(3, "3. Marinated Olives with Orange and Chile", (decimal)7.50));
            Products.Add(new Product(4, "4. Tosta de Boquerones", (decimal)9.00));
            Products.Add(new Product(5, "5. Stuffed Artichoke Hearts", (decimal)15.90));
            Products.Add(new Product(6, "6. Chicken Empanadillas”", (decimal)13.00));
            Products.Add(new Product(7, "7. Paella with Chorizo and Seafood", (decimal)20.90));
            Products.Add(new Product(8, "8. Albóndigas", (decimal)10.50));
            Products.Add(new Product(9, "9. Pera Riojana", (decimal)5.50));
            Products.Add(new Product(10, "10. Tres Leches", (decimal)6.80));
        }
    }
}
