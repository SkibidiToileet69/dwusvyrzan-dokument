using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dwusvyrzan_dokument
{
    public class DoublyLinkedList<T> 
    {
        private DoublyNode<T> head;
        private DoublyNode<T> tail;
        public DoublyLinkedList()
        {
            head = null;
            tail = null;
        }


        public void AddFirst(T data)
        {
            DoublyNode<T> newNode = new DoublyNode<T>(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Previous = newNode;
                head = newNode;
            }
        }

        public T RemoveFirst()
        {
            if (head == null)
                throw new InvalidOperationException("List is empty");
            T removedData = head.Data;
            head = head.Next;
            if (head != null)
                head.Previous = null;
            else
                tail = null;
            return removedData;
        }

        public bool Contains(T value)
        {
            DoublyNode<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(value))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public bool IsEmpty()
        {
            return head == null;
        }
        public void Reverse()
        {
            DoublyNode<T> current = head;
            DoublyNode<T> temp = null;

            while (current != null)
            {

                temp = current.Previous;
                current.Previous = current.Next;
                current.Next = temp;

                current = current.Previous;
            }

            if (temp != null)
            {
                head = temp.Previous;
            }
        }
        public void PrintList()
        {
            DoublyNode<T> current = head;


            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }

            Console.WriteLine();
        }
    }
}
