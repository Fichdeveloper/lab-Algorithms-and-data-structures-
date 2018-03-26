﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
     

namespace Homework_C
{
    class LinkedListNode<T>
    {

        public LinkedListNode(T value)
        {
            Value = value;
        }
   
        public T Value {get;internal set;}

        public LinkedListNode<T> Next { get;internal set;}
    }
}