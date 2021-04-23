using System;

namespace LinkedListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            SLLCaller();
            Console.ReadLine();
        }
        static void DLLCaller()
        {
            HelperDLL objHelper = new HelperDLL();
            DoubleLinkedList myLinkedList = new DoubleLinkedList();

            objHelper.InsertFront(myLinkedList, 10);
            objHelper.InsertFront(myLinkedList, 20);
            objHelper.InsertLast(myLinkedList, 100);
            objHelper.InsertBefore(myLinkedList.head.next.next, 30);
            objHelper.InsertAfter(myLinkedList.head.next.next, 40);
            objHelper.PrintList(myLinkedList);
            Console.WriteLine();
            objHelper.PrintList(myLinkedList);
            Console.WriteLine();
        }

        static void SLLCaller()
        {
            HelperSLL objHelper = new HelperSLL();
            SingleLinkedList myLinkedList = new SingleLinkedList();

            objHelper.InsertFront(myLinkedList, 2);
            objHelper.InsertLast(myLinkedList, 3);
            objHelper.InsertLast(myLinkedList, 4);
            objHelper.InsertLast(myLinkedList, 5);
            objHelper.InsertLast(myLinkedList, 6);
            objHelper.InsertFront(myLinkedList, 15);
            objHelper.InsertLast(myLinkedList, 20);
            objHelper.InsertFront(myLinkedList, 55);
            objHelper.InsertLast(myLinkedList, 25);
            objHelper.InsertAfter(myLinkedList.head.next.next.next.next.next, 30);
            objHelper.PrintList(myLinkedList);

            objHelper.DeleteNodebyKey(myLinkedList, 20);

            Console.WriteLine();
            objHelper.PrintList(myLinkedList);
            Console.WriteLine();

            Console.ReadLine();
        }

    }
}
