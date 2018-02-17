using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_C
{
    class Program
    {  
        static void Main()
        {
            LinkedList<int> list = new LinkedList<int> { };

            Console.WriteLine("Count: ");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Remove number: ");
            int k = Convert.ToInt32(Console.ReadLine());

            int remove_count = 0;

            for (int i=1;i<=count;i++)
            {
                list.Add(i);
            }

            list.tail.Next = list.head;

                foreach (int i in list)
                {
                int remainder_count = 0;
                    if (remove_count == k)
                    {
                       
                        list.Remove(i);
                        remove_count = 0;
                        if (list.Count == 1)
                        {                       
                            break;
                        }
                    }

                foreach (int remainder in list)
                {
                    Console.Write(" " + remainder);
                    remainder_count++;
                    if (remainder_count==list.Count)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                remove_count++;
                }

            Console.WriteLine();

            int n=0;

            foreach (int last in list)
            {
                Console.WriteLine("Last node: " + last);
                n++;
                if (n == list.Count)
                {
                    break;
                }
            }

        }
    }
}