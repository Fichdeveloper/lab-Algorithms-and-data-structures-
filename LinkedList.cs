using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_proj_C
{
    class LinkedList<T> : System.Collections.Generic.IEnumerable<T> where T:IComparable<T>
    {
        public LinkedListNode<T> head;
        public LinkedListNode<T> tail;


        public int Count
        {
            get; set;
        }

        public void Add(T value)
        {

            LinkedListNode<T> node = new LinkedListNode<T>(value);

            if (head == null)
            {
                 head = node;
                 tail = node;
            }

            else
            {
                 tail.Next = node;
               
                 tail = node;
            }
            Count++;
        }
        
        public void RemoveFirst()
        {
            if (Count!=0)
            {
                head = head.Next;
                Count--;

                if (Count == 0)
                {
                    tail = null;
                }
                
            }
        }

        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }
}