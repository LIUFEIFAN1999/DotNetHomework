using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrderManagement
{
    [Serializable]
    public class Customer
    {
        private int customerId;
        private string name;
        private string phone;

        public Customer() { }

        public Customer(string name)
        {
            this.name = name;
        }
        public Customer(int id, string name, string phone)
        {
            this.customerId = id;
            this.name = name;
            this.phone = phone;
        }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public int CustomerId { get => customerId; set => customerId = value; }

        public override bool Equals(object obj)
        {
            return obj is Customer customer &&
                   name == customer.name;
        }

        public override int GetHashCode()
        {
            int hashCode = 1926675307;
            hashCode = hashCode * -1521134295 + EqualityComparer<int>.Default.GetHashCode(customerId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(phone);
            return hashCode;
        }

        public override string ToString()
        {
            return name;
        }
    }

    [Serializable]
    public class Goods
    {
        private string name;
        private string description;
        private double price;

        public Goods() { }

        public Goods(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public Goods(string name, string description, double price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }
        public int GoodsId { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Goods goods &&
                   name == goods.name &&
                   description == goods.description &&
                   price == goods.price;
        }

        public override int GetHashCode()
        {
            int hashCode = 1442200354;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(description);
            hashCode = hashCode * -1521134295 + price.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"\t\t[Goods]\n\t\tname:{name}\tprice:{price}\tdescription:{description}";
        }
    }

    [Serializable]
    public class OrderDetails
    {
        private Goods goods;
        private int count;

        public OrderDetails() { }

        public OrderDetails(int count, Goods goods)
        {
            this.count = count;
            this.goods = goods;
        }

        public OrderDetails(int count, int goodsId)
        {
            this.count = count;
            GoodsId = goodsId;
        }

        public int Count { get => count; set => count = value; }
        public double Amount { get { return goods!=null? goods.Price* count:0; } }
        public int GoodsId { get; set; }
        public Goods Goods { get => goods; set => goods = value; }
        [Key]
        public int ItemID { get; set; }

        public override bool Equals(object obj)
        {
            return obj is OrderDetails details &&
                   details != null &&
                   EqualityComparer<Goods>.Default.Equals(goods, details.goods);
        }

        public override int GetHashCode()
        {
            int hashCode = -720357890;
            hashCode = hashCode * -1521134295 + EqualityComparer<Goods>.Default.GetHashCode(goods);
            hashCode = hashCode * -1521134295 + count.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"\t[OrderDetails]\n{goods}\tcount:{count}\tamount:{Amount}";
        }
    }

    [Serializable]
    public class Order : IComparable
    {
        private int orderId;
        private Customer customer;
        private string address;
        private List<OrderDetails> itemList = new List<OrderDetails>();

        public Order() { }

        public int OrderId { get => orderId; set => orderId = value; }
        public Customer Customer { get => customer; set => customer = value; }
        public int CustomerId { get; set; }
        public string Address { get => address; set => address = value; }
        public string CustomerName { get { return Customer != null ? Customer.Name : ""; } }
        public List<OrderDetails> ItemList { get => itemList; set => itemList = value; }
        public double Amount
        {
            get
            {
                if(itemList != null)
                {
                    double amount = 0;
                    foreach (OrderDetails item in itemList)
                    {
                        amount += item.Amount;
                    }
                    return amount;
                }
                else
                {
                    return 0;
                }
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   order != null & orderId == order.orderId;
        }

        public override int GetHashCode()
        {
            int hashCode = 2005747568;
            hashCode = hashCode * -1521134295 + EqualityComparer<int>.Default.GetHashCode(orderId);
            return hashCode;
        }

        public override string ToString()
        {
            StringBuilder orderInfo = new StringBuilder($"[Order]\nid:{orderId}\n{customer}");
            foreach (OrderDetails item in itemList)
            {
                orderInfo.Append("\n");
                orderInfo.Append(item);
            }
            return orderInfo.ToString();
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Order order))
            {
                throw new ArgumentException();
            }
            return this.OrderId.CompareTo(order.OrderId);
        }
    }
    public class OrderService
    {
        public OrderService() { }

        public void Add(Order order)
        {
            using (var db = new OrderContext())
            {
                FixOrder(order);
                db.Orders.Add(order);
                db.SaveChanges();
            }
        }

        public void Delete(int orderId)
        {
            using (var db = new OrderContext())
            {
                var order = db.Orders.Include("ItemList").FirstOrDefault(o => o.OrderId == orderId);
                if(order != null)
                {
                    db.Items.RemoveRange(order.ItemList);
                    db.Orders.Remove(order);
                    db.SaveChanges();
                }
            }
        }

        public void Modify(int orderId, Order order)
        {
            using (var db = new OrderContext())
            {
                Delete(orderId);
                Add(order);
            }
        }

        public List<Order> QueryAll()
        {
            using (var db = new OrderContext())
            {
                var query = db.Orders.Include(o => o.Customer)
                    .Include(o=>o.ItemList)
                    .Include(o => o.ItemList.Select(i=>i.Goods))
                    .Where(order => order!=null);
                return query.ToList();
            }
        }
        public Order QueryById(int id)
        {
            using (var db = new OrderContext())
            {
                var query = db.Orders
                    .Include(o => o.Customer)
                    .Include(o => o.ItemList)
                    .Include(o => o.ItemList.Select(i => i.Goods))
                    .Where(order => order.OrderId == id).FirstOrDefault();
                return query;
            }

        }
        public List<Order> QueryByName(string name)
        {
            using (var db = new OrderContext())
            {
                var query = db.Orders
                    .Include(o => o.Customer)
                    .Include(o => o.ItemList)
                    .Include(o => o.ItemList.Select(i => i.Goods))
                    .Where(order => order.ItemList.Any(
                item => item.Goods.Name == name
                )
                );
                return query.ToList();
            }
        }
        public List<Order> QueryByCustomer(string customer)
        {
            using (var db = new OrderContext())
            {
                var query = db.Orders
                    .Include(o => o.Customer)
                    .Include(o => o.ItemList)
                    .Include(o => o.ItemList.Select(i => i.Goods))
                    .Where(order => order.Customer.Name == customer);
                return query.ToList();
            }
        }
        public List<Order> QueryByAmount(double amount)
        {
            using (var db = new OrderContext())
            {
                List<Order> listOrder = QueryAll();
                var query = listOrder.Where(o => o.Amount==amount);
                return query.ToList();
            }
        }

        public void Export(string fileName)
        {
            using (var db = new OrderContext())
            {
                var query = db.Orders
                    .Include(o => o.Customer)
                    .Include(o => o.ItemList)
                    .Include(o => o.ItemList.Select(i => i.Goods)).ToList();
                XmlSerializer xmlSerializier = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    xmlSerializier.Serialize(fs,query);
                }

            }
        }

        public void Import(string filePath)
        {
            XmlSerializer xmlSerializier = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                List<Order> orders = (List<Order>)xmlSerializier.Deserialize(fs);
                if (orders == null) return;
                using (var db = new OrderContext())
                {
                    foreach (var order in orders)
                    {
                        if (! db.Orders.Any(o => o.OrderId == order.OrderId))
                        {
                            Add(order);
                        }
                    }
                }
            }
        }

        private void FixOrder(Order order)
        {
            order.CustomerId = order.Customer.CustomerId;
            order.Customer = null;
            foreach (var item in order.ItemList)
            {
                item.GoodsId = item.Goods.GoodsId;
                item.Goods = null;
            }
        }
    }

    public class CustomerService
    {
        public List<Customer> GetCustomers()
        {
            using (var db = new OrderContext())
            {
                return db.Customer.ToList();
            }
        }
    }

    public class GoodService
    {
        public Goods QueryGoods(string name)
        {
            using (var db = new OrderContext())
            {
                var query = db.Goods.Where(g => g.Name == name).FirstOrDefault();
                return query;
            }
        }
    }


    public class OrderException : ApplicationException
    {
        public OrderException(string message) : base(message) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
