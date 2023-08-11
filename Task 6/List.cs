using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public int Id { get; private set; }
    public string ProductName { get; private set; }
    public double Price { get; private set; }
   
    public Product(string productName, double price , int id)
    {

        ProductName = productName;
        Price = price;
        Id = id;
    }

    static void Main(string[] args)
    {
        List<Product> productList = new List<Product>
        {
            new Product( "Horlicks", 100 , 1 ),
            new Product("Boost",200 , 2),
            new Product("Milo", 250 , 3)
        };

       // b.Iterate through the list in descending order.
        productList.Sort((p1, p2) => p2.Price.CompareTo(p1.Price));
        foreach (Product product in productList)
        {
            Console.WriteLine(product.ProductName + ": " + product.Price);
        }

        // c.Retrieve any 2 properties from the list.
        var b = productList.Select(p => new { p.Price , p.ProductName });

        foreach(var product in b)
        {
            Console.WriteLine($"{product.ProductName} costs :{product.Price}");
        }
        // d.Retrieve only the first character from the ProductName.

        var a = productList.Select(p => p.ProductName[0]);

        foreach ( var product in a )
        {
            Console.WriteLine(product);
        }
        
        Console.ReadLine();
    }
}
