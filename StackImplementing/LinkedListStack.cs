using System;
using System.Collections.Generic;
using System.Text;

namespace StackImplementing
{
    class LinkedListStack
    {
        Node first;
        public LinkedListStack()
        {
            first = null;
        }


        public void Push(int value)
        {
            Node newNode = new Node(value);

            if (first == null)  {newNode.next = null;  }
            else { newNode.next = first; }

            first = newNode;

        }
        public void Pop()
        {
            if (first==null){return;}
              first = first.next;

        }
        public void Peek()
        {
            if (first==null) { return;}
            Console.WriteLine(first.data);
             
           
        }
        public void Show()
        {
            Node gezici = first;
            while (gezici!= null)
            { 
                Console.WriteLine(gezici.data);  
                gezici = gezici.next; 
            }
        }
}
}