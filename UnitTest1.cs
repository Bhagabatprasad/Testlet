using System.Collections.Generic;
using System.Linq;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForPreTestFirstTwoItemSuccess()
        {
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

            Testlet objTestlet = new Testlet("1", listItem);
            var actualData = objTestlet.Randomize();
            Assert.AreEqual(actualData[0].ItemType, ItemTypeEnum.Pretest);
            Assert.AreEqual(actualData[1].ItemType, ItemTypeEnum.Pretest);

        }

        [TestMethod]
        public void TestForPreTestFirstTwoItemFailure()
        {
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

            Testlet objTestlet = new Testlet("1", listItem);
            var actualData = objTestlet.Randomize();
            Assert.AreNotEqual(actualData[0].ItemType, ItemTypeEnum.Operational);
            Assert.AreNotEqual(actualData[1].ItemType, ItemTypeEnum.Operational);

        }

        [TestMethod]
        public void TestForPreTestRandomSuccess()
        {
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

            var expectedList = new List<string> {"1", "2", "3", "4"};

            Testlet objTestlet = new Testlet("1", listItem);
            var actualData = objTestlet.Randomize();
            Assert.IsTrue(expectedList.Contains(actualData[0].ItemId));
            Assert.IsTrue(expectedList.Contains(actualData[0].ItemId));

        }

        [TestMethod]
        public void TestForPreTestRandomFailure()
        {
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

            var expectedList = new List<string> { "5", "12", "3", "xx" };

            Testlet objTestlet = new Testlet("1", listItem);
            var actualData = objTestlet.Randomize();
            Assert.IsFalse(expectedList.Contains(actualData[0].ItemId));
            Assert.IsFalse(expectedList.Contains(actualData[0].ItemId));

        }

        [TestMethod]
        public void TestForPreTestFromRemainingItem()
        {
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

            Testlet objTestlet = new Testlet("1", listItem);
            var actualData = objTestlet.Randomize();
           Assert.AreEqual(actualData.Where(x => x.ItemType == ItemTypeEnum.Operational).Count(), 6);
            Assert.AreEqual(actualData.Where(x => x.ItemType == ItemTypeEnum.Pretest ).Count(), 4);

        }

        [TestMethod]
        public void TestForPreTestRandomFromRemainingItemSucess()
        {
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

            Testlet objTestlet = new Testlet("1", listItem);
            var actualData = objTestlet.Randomize();
 
            Assert.AreEqual(6,actualData.Where(x => x.ItemType == ItemTypeEnum.Operational).Count());
            Assert.AreEqual(actualData.Where(x => x.ItemType == ItemTypeEnum.Pretest).Count(), 4);
            Assert.AreEqual( 10, actualData.Count);

        }
    }
}
