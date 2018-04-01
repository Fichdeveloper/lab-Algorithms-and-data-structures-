using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Test_proj_C
{
    class Program
    {

        static void Insert(int node,ref LinkedList<int> sort)
        {
            LinkedListNode<int> copy_node = new LinkedListNode<int>(node);

            if (sort.Count==1)
            {
                if (node>=sort.head.Value)
                {
                    sort.head.Next = copy_node;
                    sort.tail = copy_node;

                }
                else
                {
                    LinkedListNode<int> temp = sort.head;

                    sort.head = copy_node;
                    sort.head.Next = temp;
                  
                }
                sort.Count++;
            }
            else
            {
                LinkedListNode<int> copy_head =  new LinkedListNode<int>(sort.head.Value);
                LinkedListNode<int> copy_tail =  new LinkedListNode<int>(sort.tail.Value);
               
                LinkedListNode<int> previous = null;
                LinkedListNode<int> current = sort.head;
                LinkedListNode<int> temp = sort.head;

                foreach (int i in sort)
                {
                    if (node<=i)
                    {
                        if (i==copy_head.Value)
                        {                       
                            sort.head = copy_node;
                            sort.head.Next = current;
                            copy_head = current;
                            break;
                        }
                        else
                        {
                            previous.Next = null;
                            previous.Next = copy_node;
                            copy_node.Next = current;                        
                            break;
                        }                     
                    }

                    if (i==copy_tail.Value)
                    {                    
                        sort.tail.Next = copy_node;
                        sort.tail = copy_node;
                        copy_tail = copy_node;
                        break;
                    }
                    previous = current;
                    current = current.Next;                    
                }
                sort.Count++;
            }
        } 



        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            LinkedList<int> sort_list =  new LinkedList<int>();

                list.Add(4);
                list.Add(20);
                list.Add(12);
                list.Add(45);

            Console.WriteLine("unsorted: ");

            foreach (int i in list)
            {
                Console.Write(i+" -> ");
            }
            Console.WriteLine();
            sort_list.Add(list.head.Value);

           list.RemoveFirst();

            foreach (int i in list)
            {
                Insert(i,ref sort_list);
            }
             
            Console.WriteLine("sorted: ");

            foreach (int i in sort_list)
            {
                Console.Write(i+" -> ");
            }
        }
    }
}
