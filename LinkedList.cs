using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_proj_C
{
    class LinkedList<R> :System.Collections.Generic.IEnumerable<R>
    {
      public  LinkedListNode<R> head;
        public LinkedListNode<R> tail;


        public int Count
        {
            get; private set;
        }

        public void Add(R value)
        {
            LinkedListNode<R> node = new LinkedListNode<R>(value);

            if (head==null)
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

      
        public void ShowList(LinkedList<R> list)
        {
            foreach (R i in list)
            {
                Console.WriteLine(i+"  ");
            }
        }

        public System.Collections.Generic.IEnumerator<R> GetEnumerator()
        {
            LinkedListNode<R> current = head;

            while (current!=null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<R>)this).GetEnumerator();
        }
    }
}
