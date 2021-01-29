using System;
using System.Collections.Generic;
using System.Text;

namespace StackImplementing
{
    class Node<T>
    {
       internal T data;
       internal  Node<T> next;

        public Node(T data)
        {
            this.data = data;
        }
       
    }

}
