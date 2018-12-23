using System;

namespace DataStructures
{

    class Queue<E>
    {
        private const int defaultMaxSize = 1000;

        //Initializes new empty queue of desiredSize if specified or defaultMaxSize
        public Queue(int desiredSize = defaultMaxSize)
        {
            
        }

        //Attempts to add specified item, returns true if successful, false otherwise
        public bool Enqueue()
        {
            return false;
        }

        //Attempts to Dequeue the specified item, returns null if unable to find item
        public E Dequeue(E item)
        {
            return default(E);
        }

        //Returns the Queue to an empty state with size of desiredSize
        public void Empty()
        {

        }

        //Returns current size of the Queue
        public int GetSize()
        {
            return 0;
        }

        //Returns true if the Queue is full
        public bool IsFull()
        {
            return false;
        }

        //Returns true if the Queue is empty
        public bool IsEmpty()
        {
            return false;
        }
    }
}