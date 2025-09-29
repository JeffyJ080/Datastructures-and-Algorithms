using System;

namespace LinkedListAlphabet
{
    // Step 1: Define the Node class
    public class Node
    {
        public char Value;     // Stores the letter
        public Node Next;      // Points to the next node in the list

        // Constructor to easily create a new node
        public Node(char value)
        {
            Value = value;
            Next = null;
        }
    }

    // Step 2: Define the LinkedList class
    public class LinkedList
    {
        private Node head;   // First node in the list
        private Node tail;   // Last node in the list (to make adding faster)

        // Method to add a node at the end
        public void AddLast(char value)
        {
            Node newNode = new Node(value);

            if (head == null) // If list is empty, new node is head and tail
            {
                head = newNode;
                tail = newNode;
            }
            else // Otherwise, append after tail
            {
                tail.Next = newNode;
                tail = newNode;
            }
        }

        // Method to print the linked list using Next references
        public void Print()
        {
            Node current = head;
            while (current != null) {
                Console.Write(current.Value + " ");
                current = current.Next; // Move to the next node
            }
            Console.WriteLine(); // New line at the end
        }
    }

    // Step 3: Test the Linked List
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList alphabetList = new LinkedList();

            // Add letters A to Z
            for (char c = 'A'; c <= 'Z'; c++) {
                alphabetList.AddLast(c);
            }

            // Print the alphabet
            Console.WriteLine("Alphabet stored in the linked list:");
            alphabetList.Print();
        }
    }
}
