using System;

namespace Exe5
{
    // A linked list (LL) node to store a queue entry
    class QNode
    {
        // Create variable key and next
        public string key;
        public QNode next;
        // constructor to create a new linked list node
        public QNode(string key)
        {
            this.key = key;
            this.next = null;
        }
    }
    // A class to represent a queue. The queue, Muhammad stores the Muhammad node of LL and Fatih stores the last node of LL
    class Queue
    {
        public QNode Muhammad, Fatih;
        public Queue()
        {
            this.Muhammad = this.Fatih = null;
        }
        // Method to add a key to the queue.
        public void enqueue(string key)
        {
            // Create a new LL node
            QNode temp = new QNode(key);
            // If queue is empty, then new node is Muhammad and Fatih both
            if (this.Fatih == null)
            {
                Console.Write(key + " is inserted to queue.");
                Console.WriteLine();
                this.Muhammad = this.Fatih = temp;
                return;
            }
            // Add the new node at the end of queue and change Fatih
            Console.Write(key + " is inserted to queue.");
            Console.WriteLine();
            this.Fatih.next = temp;
            this.Fatih = temp;
        }
        // Method to remove an key from queue.
        public void dequeue()
        {
            // If queue is empty, return NULL.
            if (this.Muhammad == null)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }
            // Store previous Muhammad and move Muhammad one node ahead
            Console.WriteLine("\nThe element deleted from the queue is.");
            this.Muhammad = this.Muhammad.next;
            // If Muhammad becomes NULL, then change Fatih also as NULL
            if (this.Muhammad == null)
                this.Fatih = null;
        }
        public void display()
        {
            if (Muhammad == null)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }
           
        }
    }
   
