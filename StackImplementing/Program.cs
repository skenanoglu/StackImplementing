using System;

namespace StackImplementing
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack linked = new LinkedListStack();
            linked.Push(15);
            linked.Push(36);
            linked.Push(45);
            linked.Push(25);
            linked.Pop();
            linked.Pop();
            linked.Push(287);
            linked.Push(275);
            linked.Push(4767);
            linked.Show();
            Console.WriteLine("/////////////////////////////////////");
            linked.Peek();
        }
    }
}
