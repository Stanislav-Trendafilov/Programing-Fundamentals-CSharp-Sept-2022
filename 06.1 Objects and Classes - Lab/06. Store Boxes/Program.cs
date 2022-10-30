using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Box> boxes = new List<Box>();
            while(input!="end")
            {
                string[] boxInfo = input.Split();
                string serialNumber = boxInfo[0];
                string itemName = boxInfo[1];
                int itemQuantity = int.Parse(boxInfo[2]);
                decimal itemPrice = decimal.Parse(boxInfo[3]);

                Box box = new Box();
                Item item = new Item();
                item.Name = itemName;
                item.Price = itemPrice;
                box.SerialNumber = serialNumber;
                box.Item = item;
                box.ItemQuantity = itemQuantity;
                
                boxes.Add(box);
                input = Console.ReadLine();
            }
            foreach (var box in boxes.OrderByDescending(x => x.PricePerBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PricePerBox:F2}");
            }
        }
    }
    public class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PricePerBox 
        {
            get { return ItemQuantity * Item.Price; }
        
        }
    }
    public class Item
    {

       public string Name { get; set; }
       public decimal Price { get; set; }

    }
}
