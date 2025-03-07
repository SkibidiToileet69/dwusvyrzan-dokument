using dwusvyrzan_dokument;

DoublyLinkedList<int> list = new DoublyLinkedList<int>();
list.AddFirst(5);
list.AddFirst(10);
list.AddFirst(20);
list.Reverse();
list.PrintList();
Console.ReadKey();