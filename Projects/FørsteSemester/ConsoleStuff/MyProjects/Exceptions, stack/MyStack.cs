using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Exceptions__stack
{
    class MyStack<T>
    {
        private T[] _stack;
        private int _top = 0;

        public T Pop()
        {
            try
            {
                return _stack[--_top];
            }
            catch
            {
                throw new MyStackIsEmptyException("Stakken er tom");
            }

        }

        public MyStack(int size)
        {
            _stack = new T[size];
        }

        public void Push(T element)
        {
            try
            {
                _stack[_top++] = element;
            }
            catch
            {
                throw new MyStackIsFullException("Stakken er fuld");
            }
        }

        public override string ToString()
        {
            return $"Max size is: {_stack.Length-1}, current top is: {_stack[_top]}, curr length is: {_top}";
        }
    }
}
