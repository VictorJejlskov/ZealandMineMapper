using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreweryThreading
{
    public class BoundedBuffer<T> where T : new()
    {
        private Queue<T> _queue;
        private Semaphore _emptySemaphore;
        private Semaphore _fullSemaphore;
        private object _lock = new object();

        public BoundedBuffer(int capacity)
        {
            _queue= new Queue<T>();
            _emptySemaphore = new Semaphore(0, capacity);
            _fullSemaphore = new Semaphore(capacity, capacity);
        }
        public int CountCurrent
        {
            get
            {
                lock (_lock)
                {
                    return _queue.Count;
                }
            }
        }


        public void Insert(T value)
        {
            _fullSemaphore.WaitOne();
            lock (_lock)
            {
                _queue.Enqueue(value);
            }
            _emptySemaphore.Release();

        }
        public T Remove()
        {
            T value;
            _emptySemaphore.WaitOne();
            lock (_lock)
            {
                value = _queue.Dequeue();
            }
            _fullSemaphore.Release();
            return value;

        }
    }

}
