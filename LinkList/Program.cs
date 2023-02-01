using System.Collections.Generic;

namespace LinkList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~ WELCOME TO LINKLIST ~~~");
            /* SimpleLinkList a = new SimpleLinkList();
              a.add(56);
              a.add(30);
              a.add(70);
              a.show();*/
            /*AddingLinkList a = new AddingLinkList();
            a.add(56);
            a.add(30);
            a.add(70);
            a.show();*/
            /*  LinkedListAppending appending= new LinkedListAppending();
              appending.add(70);
              appending.AddFirst(30);
              appending.AddFirst(56);
              appending.show();*/
            /* UC4_LinkList a = new UC4_LinkList();
             a.add(70);
             a.add(56);
             a.AddBTW(1, 30);
             a.show();*/
            /* DeleteTheFirstElement a = new DeleteTheFirstElement();
             a.add(56);

             a.add(70);
             a.AddBTW(1, 30);
             a.remove(0);
             a.show();*/
            DeleteTheLastElement a = new DeleteTheLastElement();
            a.add(56);
            a.add(70);
            a.AddBTW(1, 30);
            a.remove(2);
            a.show();
        }
    }
}