using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace 
{
    class Program
    {
        static void Main(string[] args)
        {
           
            LinkedList<int> list = new LinkedList<int>();
            Console.Write("Count= ");
            int count = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();

            for (int i=0;i<count;i++)
            {
                list.Add(random.Next(1, 10));      
            }
            list.tail.Next = list.head;
            list.ShowList(list);
           
        }
    }
}
