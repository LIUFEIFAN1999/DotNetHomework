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
    }
}