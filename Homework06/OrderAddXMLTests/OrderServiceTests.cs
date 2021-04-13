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
        private Order order2;
        private Order order3;
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
            order2 = new Order("00002", customer1, "Shanghai", item1);
            order3 = new Order("00003", customer2, "Beijing", item3);
            
            orderService = new OrderService();
            orderService.Add(order0);
            orderService.Add(order1);
            orderService.Add(order2);
        }

        [TestMethod()]
        public void OrderServiceTest()
        {
            Assert.IsNotNull(new OrderService().OrderList);
        }

        [TestMethod()]
        public void AddTest1()
        {
            Assert.AreEqual(orderService.OrderList.Count, 3);
            orderService.Add(order3);
            Assert.AreEqual(orderService.OrderList.Count, 4);
            CollectionAssert.AreEqual(orderService.OrderList, new List<Order>{order0, order1, order2, order3});
        }

        [TestMethod()]
        [ExpectedException(typeof(OrderException))]
        public void AddTest2()
        {
            orderService.Add(order0);
        }

        [TestMethod()]
        public void DeleteTest1()
        {
            Assert.AreEqual(orderService.OrderList.Count, 3);
            orderService.Delete("00000");
            Assert.AreEqual(orderService.OrderList.Count, 2);
            CollectionAssert.AreEqual(orderService.OrderList, new List<Order> {order1, order2});
        }

        [TestMethod()]
        [ExpectedException(typeof(OrderException))]
        public void DeleteTest2()
        {
            orderService.Delete("00003");
        }

        [TestMethod()]
        public void Modify_AddItemTest1()
        {
            Assert.AreEqual(orderService.OrderList[0].ItemList.Count, 1);
            orderService.Modify_AddItem("00000", item1);
            Assert.AreEqual(orderService.OrderList[0].ItemList.Count, 2);
            CollectionAssert.AreEqual(orderService.OrderList[0].ItemList, new List<OrderDetails> {item0, item1});
        }

        [TestMethod()]
        public void Modify_AddItemTest2()
        {
            Assert.AreEqual(orderService.OrderList[0].ItemList.Count, 1);
            orderService.Modify_AddItem("00000", item0);
            Assert.AreEqual(orderService.OrderList[0].ItemList.Count, 1);
            Assert.AreEqual(orderService.OrderList[0].ItemList[0].Count, 2);
        }

        [TestMethod()]
        [ExpectedException(typeof(OrderException))]
        public void Modify_AddItemTest3()
        {
            orderService.Modify_AddItem("00003", item0);
        }

        [TestMethod()]
        public void Modify_DeleteItemTest1()
        {
            Assert.AreEqual(orderService.OrderList[0].ItemList.Count, 1);
            orderService.Modify_DeleteItem("00000", item0);
            Assert.AreEqual(orderService.OrderList[0].ItemList.Count, 0);
        }

        [TestMethod()]
        [ExpectedException(typeof(OrderException))]
        public void Modify_DeleteItemTest2()
        {
            orderService.Modify_DeleteItem("00003", item0);
        }

        [TestMethod()]
        [ExpectedException(typeof(OrderException))]
        public void Modify_DeleteItemTest3()
        {
            orderService.Modify_DeleteItem("00000", item1);
        }

        [TestMethod()]
        public void QueryByIdTest()
        {
            Assert.AreEqual(orderService.QueryById("00000"), order0);
        }

        [TestMethod()]
        public void QueryByNameTest()
        {
            CollectionAssert.AreEqual(orderService.QueryByName("computer"), new List<Order> { order0 });
        }

        [TestMethod()]
        public void QueryByCustomerTest()
        {
            CollectionAssert.AreEqual(orderService.QueryByCustomer(customer1), new List<Order> { order0, order2 });
        }

        [TestMethod()]
        public void QueryByAmountTest()
        {
            CollectionAssert.AreEqual(orderService.QueryByAmount(4325.99), new List<Order> { order0 });
        }

        [TestMethod()]
        public void SortTest()
        {
            orderService.Sort();
            CollectionAssert.AreEqual(orderService.OrderList, new List<Order> { order0, order1, order2 });
        }

        [TestMethod()]
        public void SortTest1()
        {
            orderService.Sort((p1,p2)=> p2.Amount.CompareTo(p1.Amount));
            CollectionAssert.AreEqual(orderService.OrderList, new List<Order> { order2, order0, order1 });
        }

        [TestMethod()]
        public void ExportTest1()
        {
            string filePath = "orderList";
            orderService.Export(filePath);
            Assert.IsTrue(File.Exists(filePath));
        }


        [TestMethod()]
        public void ImportTest1()
        {
            string filePath = @"C:\Users\19352\source\repos\DotNetHomework1\Homework06\OrderAddXML\bin\Debug\orderList.xml";
            orderService.Import(filePath);
            Assert.AreEqual(orderService.OrderList[0], order0);
        }

        [TestMethod()]
        [ExpectedException(typeof(FileNotFoundException))]
        public void ImportTest2()
        {
            string filePath = @"D:\orderList.xml";
            orderService.Import(filePath);
        }
    }
}