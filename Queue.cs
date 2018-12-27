using System;

namespace DataStructures
{

    class Queue<E>
    {
        private const int defaultMaxSize = 1000;
        private int size, maxSize, last;
        private E[] storage;

        //Initializes new empty queue of desiredSize if specified or defaultMaxSize
        public Queue(int desiredSize = defaultMaxSize)
        {
            size = 0;
            maxSize = desiredSize;
            storage = new E[maxSize];
        }

        //Attempts to add specified item, returns true if successful, false otherwise
        public bool Enqueue(E item)
        {
            if (IsFull())
            {
                return false;
            }
            if (last == maxSize)
            {
                last = 0;
            }
            else
            {
                last++;
            }

            storage[last] = item;
            size++;
            
            return true;
        }

        //Attempts to Dequeue the specified item, returns null if unable to find item
        public E Dequeue(E item)
        {
            return default(E);
        }

        //Return true if the specified item is in the Queue
        public bool Contains(E item)
        {
            return false;
        }

        //Returns the Queue to an empty state with original size
        public void Empty()
        {
            size = 0;
            storage = new E[this.maxSize];
        }

        //Returns current size of the Queue
        public int GetSize()
        {
            return size;
        }

        //Returns true if the Queue is full
        public bool IsFull()
        {
            return size == maxSize;
        }

        //Returns true if the Queue is empty
        public bool IsEmpty()
        {
            return size == 0;
        }
    }
}