using System;
using System.Collections.Generic;

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
            last = 0;
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
            if (last == maxSize - 1)
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

        //Attempts to Dequeue the specified item, throws InvalidOperationException if the Queue is empty
        public E Dequeue()
        {
            if (IsEmpty())
            {
                throw new System.InvalidOperationException("The Queue is empty.");
            }
            else
            {
                return default(E);
            }
        }

        //Return true if the specified item is in the Queue
        public bool Contains(E item)
        {
            for (int i = 0; i < maxSize; i++)
            {
                if (storage[i] != null)
                {
                    if (EqualityComparer<E>.Default.Equals(storage[i], item))
                    {
                        return true;
                    }
                }
            }
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