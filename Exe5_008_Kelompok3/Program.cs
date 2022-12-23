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
       
    }
   
