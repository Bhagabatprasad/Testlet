using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        private static Random rnd;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Item> listItem = new List<Item>()
            {
                new Item {ItemId = "1", ItemType = ItemTypeEnum.Pretest},
                new Item {ItemId = "2", ItemType = ItemTypeEnum.Pretest},
                new Item {ItemId = "3", ItemType = ItemTypeEnum.Pretest},
                new Item {ItemId = "4", ItemType = ItemTypeEnum.Pretest},
                new Item {ItemId = "5", ItemType = ItemTypeEnum.Operational},
                new Item {ItemId = "6", ItemType = ItemTypeEnum.Operational},
                new Item {ItemId = "7", ItemType = ItemTypeEnum.Operational},
                new Item {ItemId = "8", ItemType = ItemTypeEnum.Operational},
                new Item {ItemId = "9", ItemType = ItemTypeEnum.Operational},
                new Item {ItemId = "10", ItemType = ItemTypeEnum.Operational}

            };

            Testlet obj = new Testlet("1", listItem);
            var result = obj.Randomize();
        }
    }
}
