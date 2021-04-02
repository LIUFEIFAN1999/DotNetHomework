using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderAddXML;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAddXML.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        private Customer customer1;
        private Customer customer2;
        private Goods pc;
        private Goods guitar;
        private Goods shirt;
        private Goods bag;
        private OrderDetails item0;
        private OrderDetails item1;
        private OrderDetails item2;
        private OrderDetails item3;
        private Order order0;
        private Order order1;
        private OrderService orderService;

        [TestInitialize]
        public void Initialize()
        {
            customer1 = new Customer("00001", "LiuFeifan", "18812345678");
            customer2 = new Customer("00002", "Liuxia", "18202939333");
            pc = new Goods("computer", "Lenovo 16G 512G i5", 4325.99, 1000);
            guitar = new Goods("guitar", "Mesopotamia S200 41", 2680, 2000);
            shirt = new Goods("T-Shirt", "Li-Ning 2021", 129.98, 50);
            bag = new Goods("handbag", "Dior Latest", 10000, 500);
            item0 = new OrderDetails(pc, 1);
            item1 = new OrderDetails(guitar, 2);
            item2 = new OrderDetails(shirt, 3);
            item3 = new OrderDetails(bag, 1);
            order0 = new Order("00000", customer1, "Wuhan", item0);
            order1 = new Order("00001", customer2, "Nanchang", item2);
            orderService = new OrderService();
        }

        [TestMethod()]
        public void OrderServiceTest()
        {
            Assert.IsNotNull(new OrderService().OrderList);
        }

        [TestMethod()]
        public void AddTest1()
        {
            orderService.Add(order0);
            Assert.AreEqual(orderService.OrderList[0], order0);
        }

        [TestMethod()]
        [ExpectedException(typeof(OrderException))]
        public void AddTest2()
        {
            orderService.Add(order0);
            orderService.Add(order0);
        }

        [TestMethod()]
        public void DeleteTest1()
        {
            orderService.Add(order0);
            orderService.Delete("00000");
            Assert.IsTrue(orderService.OrderList.Count == 0);
        }

        [TestMethod()]
        [ExpectedException(typeof(OrderException))]
        public void DeleteTest2()
        {
            orderService.Add(order0);
            orderService.Delete("00001");
        }

        [TestMethod()]
        public void Modify_AddItemTest1()
        {
            orderService.Add(order0);
            orderService.Modify_AddItem("00000", item1);
            Assert.AreEqual(orderService.OrderList[0].ItemList[1], item1);
        }

        [TestMethod()]
        public void Modify_AddItemTest2()
        {
            orderService.Add(order0);
            orderService.Modify_AddItem("00000", item0);
            Assert.AreEqual(orderService.OrderList[0].ItemList[0].Count, 2);
        }

        [TestMethod()]
        [ExpectedException(typeof(OrderException))]
        public void Modify_AddItemTest3()
        {
            orderService.Add(order0);
            orderService.Modify_AddItem("00001", item0);
        }

        [TestMethod()]
        public void Modify_DeleteItemTest1()
        {
            orderService.Add(order0);
            orderService.Modify_DeleteItem("00000", item0);
            Assert.IsTrue(orderService.OrderList[0].ItemList.Count == 0);
        }

        [TestMethod()]
        [ExpectedException(typeof(OrderException))]
        public void Modify_DeleteItemTest2()
        {
            orderService.Modify_DeleteItem("00000", item0);
        }

        [TestMethod()]
        [ExpectedException(typeof(OrderException))]
        public void Modify_DeleteItemTest3()
        {
            orderService.Add(order0);
            orderService.Modify_DeleteItem("00000", item1);
        }

        [TestMethod()]
        public void QueryByIdTest()
        {
            orderService.Add(order0);
            orderService.Add(order1);
            Assert.AreEqual(orderService.QueryById("00000"), order0);
        }

        [TestMethod()]
        public void QueryByNameTest()
        {
            orderService.Add(order0);
            orderService.Add(order1);
            CollectionAssert.AreEqual(orderService.QueryByName("computer"), new List<Order> { order0 });
        }

        [TestMethod()]
        public void QueryByCustomerTest()
        {
            orderService.Add(order0);
            orderService.Add(order1);
            CollectionAssert.AreEqual(orderService.QueryByCustomer(customer1), new List<Order> { order0 });
        }

        [TestMethod()]
        public void QueryByAmountTest()
        {
            orderService.Add(order0);
            orderService.Add(order1);
            CollectionAssert.AreEqual(orderService.QueryByAmount(4325.99), new List<Order> { order0 });
        }

        [TestMethod()]
        public void SortTest()
        {
            orderService.Add(order0);
            orderService.Add(order1);
            orderService.Sort();
            CollectionAssert.AreEqual(orderService.OrderList, new List<Order> { order0, order1 });
        }

        [TestMethod()]
        public void SortTest1()
        {
            orderService.Add(order0);
            orderService.Add(order1);
            orderService.Sort((p1,p2)=> p2.Amount.CompareTo(p1.Amount));
            CollectionAssert.AreEqual(orderService.OrderList, new List<Order> { order0, order1 });
        }

        [TestMethod()]
        public void ExportTest()
        {
            string filePath = "orderList.xml";
            orderService.Export(filePath);
            Assert.IsTrue(File.Exists(filePath));
        }

        [TestMethod()]
        public void ImportTest()
        {
            string filePath = @"C:\Users\19352\source\repos\DotNetHomework1\Homework06\OrderAddXML\bin\Debug\orderList.xml";
            orderService.Import(filePath);
            Assert.AreEqual(orderService.OrderList[0], order0);
        }
    }
}