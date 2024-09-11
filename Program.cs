using System;
using System.Globalization;
using ExercicioHerancaPolimorfismo.Entities;

namespace ExercicioHerancaPolimorfismo
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int qtyProducts = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtyProducts; i++)
            {
                Console.WriteLine($"Product #{i + 1} data: ");
                Console.Write("Commom, used or imported (c/u/i)? ");
                string productCategory = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                                                
                if (productCategory == "i")
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    ImportedProduct importedProduct = new ImportedProduct(name, price, customsFee);

                    products.Add(importedProduct);
                }
                else if (productCategory == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateOnly manufactureDate = DateOnly.Parse(Console.ReadLine());

                    UsedProduct usedProduct = new UsedProduct(name, price, manufactureDate);

                    products.Add(usedProduct);
                }
                else
                {
                    Product product = new Product(name, price);
                    products.Add(product);
                }
            }

            Console.WriteLine();

            Console.WriteLine("PRICE TAGS: ");

            foreach (Product pro in products)
            {
                Console.Write(pro.PriceTag().ToString());
            }
        }
    }
}