using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskDataWorks
{
    public interface IDoubleLinkedListNode<T>
    {
        T Value { get; set; }
        IDoubleLinkedListNode<T> Next { get; set; }
        IDoubleLinkedListNode<T> Prev { get; set; }
    }
}
