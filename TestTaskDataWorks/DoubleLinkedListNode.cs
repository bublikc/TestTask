using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskDataWorks
{
    public class DoubleLinkedListNode<T> : IDoubleLinkedListNode<T>
    {
        public T Value { get; set; }
        public IDoubleLinkedListNode<T> Next { get; set; }
        public IDoubleLinkedListNode<T> Prev { get; set; }
    }
}
