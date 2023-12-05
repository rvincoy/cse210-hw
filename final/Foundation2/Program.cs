using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello Foundation2 World!");
        Console.Clear();
        Customer customer1 = new Customer("Rolando","2700 Dempster St", "Park Ridge", "IL", "USA");
        Address address = new Address("#7 CR 6447", "Kirtland", "Davao Del Sur","Philippines");
        Customer customer2 = new Customer();
        customer2.SetName("Mary Batungbakal");
        customer2.SetAddress(address);
        Product p1 = new Product("Johnny Walker", "Whiskey", 32.99, 100);
        Product p2 = new Product("Cream Silk", "Shampoo", 10.99,3000);
        Product p3 = new Product("Nike", "Shoes", 99, 50);
        Order o1 = new Order(customer1);
        Order o2 = new Order(customer2);
        Product p4 = new Product("HP", "Laptop",799, 1);
        Product p5 = new Product("S123456 Necklace", "Jewelry", 999,1);
        Product p6 = new Product("Uggs", "Boots", 299, 5);
        o1.AddProduct(p1);
        o1.AddProduct(p2);
        o1.AddProduct(p3);
        o2.AddProduct(p4);
        o2.AddProduct(p5);
        o2.AddProduct(p6);
        Console.WriteLine("Order 1:\n\n");
        Console.WriteLine(o1.PackingLabel() + "\n");
        Console.WriteLine(o1.ShippingLabel() + "\n\n");
        Console.WriteLine("Total Cost = " + o1.TotalCost());
        Console.WriteLine("----------------------------------------------");
        List<Product> products = o1.GetProducts();
        foreach (Product product in products)
        {
            Console.WriteLine($"{product.GetName()}, {product.GetProduct()}, {product.GetPrice()}, {product.GetQuantity()} = {product.TotalPrice()}");
        }
//        Thread.Sleep(3000);
 //       Console.Clear();
        Console.WriteLine("Order 2:\n\n");
        Console.WriteLine(o2.PackingLabel() +"\n");
        Console.WriteLine(o2.ShippingLabel() + "\n\n");
        Console.WriteLine("Total Cost = " + o2.TotalCost());
        Console.WriteLine("----------------------------------------------");
        products = o2.GetProducts();
        foreach (Product product in products)
        {
            Console.WriteLine($"{product.GetName()}, {product.GetProduct()}, {product.GetPrice()}, {product.GetQuantity()} = {product.TotalPrice()}");
        }
    }
}