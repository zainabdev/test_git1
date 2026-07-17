using System;
using System.Collections.Generic;

class Product
{
    public int id;
    public string name;
    public float price;
    public string category;
    public string brandName;
    public string country;
}

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();
        int option = 0;

        while (option != 4)
        {
            Console.Clear();
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Show Products");
            Console.WriteLine("3. Total Store Worth");
            Console.WriteLine("4. Exit");
            Console.Write("Enter Option: ");

            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Product p = new Product();

                Console.Write("Enter ID: ");
                p.id = int.Parse(Console.ReadLine());

                Console.Write("Enter Name: ");
                p.name = Console.ReadLine();

                Console.Write("Enter Price: ");
                p.price = float.Parse(Console.ReadLine());

                Console.Write("Enter Category: ");
                p.category = Console.ReadLine();

                Console.Write("Enter Brand Name: ");
                p.brandName = Console.ReadLine();

                Console.Write("Enter Country: ");
                p.country = Console.ReadLine();

                products.Add(p);
            }

            else if (option == 2)
            {
                foreach (Product p in products)
                {
                    Console.WriteLine("ID: " + p.id);
                    Console.WriteLine("Name: " + p.name);
                    Console.WriteLine("Price: " + p.price);
                    Console.WriteLine("Category: " + p.category);
                    Console.WriteLine("Brand: " + p.brandName);
                    Console.WriteLine("Country: " + p.country);
                    Console.WriteLine("--------------------");
                }

                Console.ReadKey();
            }

            else if (option == 3)
            {
                float total = 0;

                foreach (Product p in products)
                {
                    total = total + p.price;
                }

                Console.WriteLine("Total Store Worth: " + total);
                Console.ReadKey();
            }
        }
    }
}