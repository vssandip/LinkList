using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    internal class DeleteTheLastElement
    {
        public Node head;

        public void add(int data)
        {
            Node node = new Node();
            node.data = data;
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        public void AddFirst(int data)
        {
            Node node = new Node();
            node.data = data;
            node.next = head;
            head = node;
        }
        public void AddBTW(int index, int data)
        {
            Node node = new Node();
            node.data = data;
            Node temp = head;
            for (int i = 0; i < index - 1; i++)
            {
                temp = temp.next;
            }
            node.next = temp.next;
            temp.next = node;
        }
        public void remove(int index)
        {
            if (index == 0)
            {
                head = head.next;
            }
            else
            {
                Node temp = head;
                Node n1 = null;
                for (int i = 0; i < index - 1; i++)
                {
                    temp = temp.next;
                }
                n1 = temp.next;
                temp.next = n1.next;
            }
        }
        public void show()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
