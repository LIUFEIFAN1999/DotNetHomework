using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void Foreach(Action<T> action)
        {
            Node<T> index = head;
            while (index != null)
            {
                action(index.Data);
                index = index.Next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intList = new GenericList<int>();
            for (int i = 0; i < 10; i++)
            {
                intList.Add(i);
            }
            int maxmium = int.MinValue, minimium = int.MaxValue, sum = 0;
            intList.Foreach(data => Console.WriteLine(data));
            intList.Foreach(data => {
                maxmium = maxmium < data ? data : maxmium;
                minimium = minimium > data ? data : minimium;
                sum += data;
            });
            Console.WriteLine($"MaxValue:{maxmium}; MinValue:{minimium}; Sum:{sum}");
        }
    }
}
