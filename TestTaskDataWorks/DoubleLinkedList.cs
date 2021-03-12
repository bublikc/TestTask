using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskDataWorks
{
    public class DoubleLinkedList<T> : IDoubleLinkedList<T>
    {
        public IDoubleLinkedListNode<T> First { get; set; }
        public IDoubleLinkedListNode<T> Last { get; set; }

        public void AddFirst(T value)
        {
            var newElem = new DoubleLinkedListNode<T>
            {
                Value = value,
                Prev = null,
                Next = First
            };
            if (First != null)
                First.Prev = newElem;
            else
                First = Last = newElem;
            First = newElem;
        }

        public void AddLast(T value)
        {
            var newElem = new DoubleLinkedListNode<T>
            {
                Value = value,
                Prev = Last,
                Next = null
            };

            if (First == null)
            {
                First = Last = newElem;
            }

            Last.Next = newElem;
            Last = newElem;
        }

        public void Reverse()
        {
            if (First == null)
                return;

            var currentElem = First;
            while (currentElem != null)
            {
                var tmp = currentElem.Next;
                currentElem.Next = currentElem.Prev;
                currentElem.Prev = tmp;

                currentElem = currentElem.Prev;
            }
            var lastTmp = Last;
            Last = First;
            First = lastTmp;


        }

        public void Print()
        {
            var current = First;
            while (current != null)
            {
                Console.Write(current.Value);
                Console.Write(" ");
                current = current.Next;
            }
            Console.WriteLine();
        }

    }
}
