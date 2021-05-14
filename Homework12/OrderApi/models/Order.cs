using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TodoApi.Models{
    public class Order : IComparable
    {
        private int orderId;
        private Customer customer;
        private string address;
        private List<OrderDetails> itemList = new List<OrderDetails>();

        public Order() { }
        public Order(int id, Customer customer, string address, OrderDetails item)
        {
            this.orderId = id;
            this.customer = customer;
            this.address = address;
            itemList.Add(item);
        }
        public int OrderId { get => orderId; set => orderId = value; }
        public Customer Customer { get => customer; set => customer = value; }
        public int CustomerId {get;set;}
        public string CustomerName{ get{return Customer!=null? Customer.Name:"";}}
        public string Address { get => address; set => address = value; }
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
}