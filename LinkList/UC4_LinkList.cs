﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    internal class UC4_LinkList
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
