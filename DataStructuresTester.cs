using System;

namespace DataStructures{

    class DataStructuresTester{
        
        public DataStructuresTester()
        {
            
        }

        public void TestQueue()
        {
            Console.WriteLine("DataStructuresTester: Testing Queue");

            Queue<int> q = new Queue<int>(1);

            //tests on empty queue
            Console.WriteLine($"GetSize should be 0: {q.GetSize()}");
            Console.WriteLine($"IsFull should be false: {q.IsFull()}");
            Console.WriteLine($"IsEmpty should be true: {q.IsEmpty()}");
            Console.WriteLine($"Contains should be false: {q.Contains(1)}");

            //tests on full queue
            Console.WriteLine($"Enqueue should be true: {q.Enqueue(1)}");
            Console.WriteLine($"GetSize should be 1: {q.GetSize()}");
            Console.WriteLine($"IsFull should be true: {q.IsFull()}");
            Console.WriteLine($"IsEmpty should be false: {q.IsEmpty()}");
            Console.WriteLine($"Enqueue should be false: {q.Enqueue(1)}");

            //testing contains on populated queue
            Console.WriteLine($"Contains should be true: {q.Contains(1)}");
            Console.WriteLine($"Contains should be false: {q.Contains(0)}");
        }
    }
}