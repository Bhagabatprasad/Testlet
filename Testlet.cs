using System.Collections;

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    ///  Test let Class
    /// </summary>
    public class Testlet
    {
        public string TestletId;

        private readonly List<Item> Items;

        public static Random RandomForPretest;

        /// <summary>
        /// Designated constructor
        /// </summary>
        /// <param name="testletId"></param>
        /// <param name="items"></param>
        public Testlet(string testletId, List<Item> items)

        {
            TestletId = testletId;
            Items = items;
        }

        public List<Item> Randomize()

        {
            //Items private collection has 6 Operational and 4 Pretest Items. Randomize the order of these items as per the requirement (with TDD)

            // new List for the item to be stored.
            var randomList = new List<Item>();

            // Add the first 2 pretest item randomly to the List
            while (randomList?.Where(x => x.ItemType == ItemTypeEnum.Pretest).Count() < 2)
            {
                RandomForPretest = new Random();
                int r = RandomForPretest.Next(Items.Count - 1);
                if (this.Items[r].ItemType == ItemTypeEnum.Pretest)
                {
                    randomList.Add(this.Items[r]);
                }
            }

            // Remaining list Item after adding the 1st two pretest element
            var remainingListItem = this.Items.Where(x => !randomList.Contains(x)).ToList();

            // Read randomly from the remaining list and add the item into random List 
            //remainingListItem.ForEach(x =>
            //{
            //    RandomForOperational = new Random();
            //    int r = RandomForOperational.Next(remainingListItem.Count - 1);
            //    randomList.Add(remainingListItem[r]);
            //});

            var newRemainingListItem = RandomReadFromList(remainingListItem, 8);
            newRemainingListItem.ForEach(x => { randomList.Add(x); });

            return randomList;
        }

        public List<Item> RandomReadFromList(List<Item> listItems, int count)
        {
            var listToReturn = new List<Item>();

            if (listItems.Count != count)
            {
                var deck = CreateShuffledDeck(listItems);

                for (var i = 0; i < count; i++)
                {
                    var arrayItems = deck.Pop();
                    listToReturn.Add((Item)arrayItems);
                }

                return listToReturn.ToList();
            }

            return listToReturn;
        }

        public static Stack CreateShuffledDeck(List<Item> list)
        {

            var random = new Random();
            var stack = new Stack();
            while (list.Count > 0)
            {
                var randomIndex = random.Next(0, list.Count);
                var randomItem = list[randomIndex];
                list.RemoveAt(randomIndex);
                stack.Push(randomItem);
            }

            return stack;
        }
    }
}
