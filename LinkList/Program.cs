using System.Collections.Generic;

namespace LinkList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~ WELCOME TO LINKLIST ~~~");
           SimpleLinkList a = new SimpleLinkList();
            a.add(56);
            a.add(30);
            a.add(70);
            a.show();
        }
    }
}