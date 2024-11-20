using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(8);
        list.Add(48);
        list.Add(5);
        foreach (int i in list)
        {
            Console.WriteLine(i);
        }
       Dictionary<int,string> d = new Dictionary<int, string>();
        d.Add(1,"hi");
        d.Add(2, "vidya");
        d.Add(3, "eee");
        d.Add(4,"good");
        foreach (KeyValuePair<int, string> kvp in d)
        {
            Console.WriteLine(kvp.Key + " " + kvp.Value);
        }
        Stack<int> stack = new Stack<int>();
        stack.Push(345);
        stack.Push(69);
        stack.Push(809);
        stack.Push(999);
        stack.Peek();
        stack.Pop();
        foreach (object obj1 in stack)
        {
            Console.WriteLine(obj1);
        }
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);
        queue.Dequeue();
        foreach (object obj2 in queue)
        {
            Console.WriteLine(obj2);
        }

    }
}
