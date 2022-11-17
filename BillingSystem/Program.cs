using BillingSystem.Entities;
using BillingSystem.Repositories;

BillRepository BillRepo = new BillRepository();
ProductRepository ProductRepo = new ProductRepository();

while (true)
{
    Console.WriteLine("Welcome to Billing System!");
    Console.WriteLine("Please select an action from the following menu:");
    Console.WriteLine(" 1 - see all bills");
    Console.WriteLine(" 2 - see one bill");
    Console.WriteLine(" ENTER - clear entered data");
    Console.WriteLine(" X - close the app");
    

    string command = Console.ReadLine();

    switch (command)
    {
        case "1":
            GetAllBill(BillRepo, ProductRepo);
            break;
        case "2":
            GetOneBill(BillRepo, ProductRepo);
            break;
        case "x":
            return;
        default:
            Console.Clear();
            break;
    }
}

static void GetAllBill(BillRepository billRepo, ProductRepository ProductRepo)
{
    decimal allBilsTotalPrice = 0;

    foreach (Bill bill in billRepo.Bills)
    {
        Console.WriteLine("Bill's ID:" + bill.Id);
        bill.TotalPrice = 0;
        for (int i = 0; i < bill.Product.Count; i++)
        {
            Console.WriteLine(ProductRepo.Products[bill.Product[i]].Name + " " + ProductRepo.Products[bill.Product[i]].Price);
            bill.TotalPrice = bill.TotalPrice + ProductRepo.Products[bill.Product[i]].Price;
        }

        Console.WriteLine("Total: " + bill.TotalPrice);
        allBilsTotalPrice = allBilsTotalPrice + bill.TotalPrice;
    }
    Console.WriteLine("Total for all bills: " + allBilsTotalPrice);


}

static void GetOneBill(BillRepository billRepo, ProductRepository ProductRepo)
{
    Console.WriteLine("Enter a bill's ID:");

    if (int.TryParse(Console.ReadLine(), out int billId))
    {
        if (billId <= billRepo.Bills.Count)
        {
            var bill = billRepo.Bills[billId - 1];

            Console.WriteLine("Bill's ID:" + bill.Id);
            bill.TotalPrice = 0;
            for (int i = 0; i < bill.Product.Count; i++)
            {
                Console.WriteLine(ProductRepo.Products[bill.Product[i]].Name + " " + ProductRepo.Products[bill.Product[i]].Price);
                bill.TotalPrice = bill.TotalPrice + ProductRepo.Products[bill.Product[i]].Price;
            }

            Console.WriteLine("Total Price: " + bill.TotalPrice);


        }
        else
        {
            Console.Clear();
            Console.WriteLine("Oops,no such bill was found. Check again!");
        }
    }
}