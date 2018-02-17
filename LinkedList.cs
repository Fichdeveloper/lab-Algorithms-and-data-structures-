using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework_C
{

    class LinkedList<T> : System.Collections.Generic.IEnumerable<T> 
    {
       public LinkedListNode<T> head;
       public LinkedListNode<T> tail;

        public int Count { get; private set; }

        public void Add(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);

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

        public bool Remove(T node)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current =head;

            while (current!=null)
            {
                if (current.Value.Equals(node))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;


                        if (current.Next == null)
                        {
                            tail = previous;
                        }
                    }
                    else
                    {
                        head = head.Next;

                        if (head == null)
                        {
                            tail = null;
                        }
                    }
                    Count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = head;

            while (current!=null)
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
