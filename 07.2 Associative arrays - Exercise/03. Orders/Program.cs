using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string, Dictionary<double, int>> products = new Dictionary<string, Dictionary<double, int>>();
           string input = Console.ReadLine();
           while(input!="buy")
           {
               string[] cmdArg = input.Split(" ");
               string product = cmdArg[0];
               double price = double.Parse(cmdArg[1]);
               int count = int.Parse(cmdArg[2]);
               if(!products.ContainsKey(product))
               {
                   products[product] = new Dictionary<double, int>();
                   products[product].Add(price, count);
                  
               }
               else
               {
                    Dictionary<double, int> priceAndCount = new Dictionary<double,int>();
                    int oldCount=0;
                    double oldPrice;
                    foreach (var product1 in products.Where(x=>x.Key==product))
                    {
                        foreach (var product2 in product1.Value)
                        {
                            oldCount=product2.Value;
                            oldPrice = product2.Key;
                        }
                    }
                    //double oldCount = priceAndCount.Values;
                    products.Remove(product);
                    products[product] = new Dictionary<double, int>();
                    products[product].Add(price, count + oldCount);
               }
           
               input = Console.ReadLine();
           }
           Dictionary<string, double> productAndPrice = new Dictionary<string, double>();
           foreach (var product in products)
           {
               foreach (var item in product.Value)
               {
                   productAndPrice[product.Key] = item.Key * item.Value;
               }
           }
           foreach (var product in productAndPrice)
           {
               Console.WriteLine($"{product.Key} -> {product.Value:f2}");
           }
        }
    }
}
