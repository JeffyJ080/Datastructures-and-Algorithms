using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Datastructures_in_C_.Examples_and_Practice
{
    internal class DataStructures
    {
        // Write a program that pushes 5 numbers onto a stack<int> and then pops all elements
        static void Stacks()
        {
            Stack<int> stack = new Stack<int>();

            // Push elements
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine("Stack Elements Popped: ");

            while (stack.Count > 0) {
                Console.WriteLine(stack.Pop());
            }
        }

        static void Queues()
        {
            // Write a program that adds 2 customer names and then serves them in order
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue("C");

            Console.WriteLine("Customers served");

            while (queue.Count > 0) {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
