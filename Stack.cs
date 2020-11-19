using System;
using System.Collections;
using System.Collections.Generic;

namespace Balanced_Bracket_Sequence
{
    class Stack<T> : IEnumerable<T>
    {
        public T[] elements;
        public int top = -1;

        public T Top
        {
            get
            {
                try
                {
                    return elements[top];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool StackEmpty
        {
            get
            {
                return (top == -1);
            }
        }

        public Stack(int quantity)
        {
            try
            {
                elements = new T[quantity];
            }
            catch(ArgumentException)
            {
                throw new ArgumentException();
            }
        }

        public void Push(T newElement)
        {
            if(top >= elements.Length)
            {
                Console.WriteLine("The element went over the top of the stack");
                return;
            }

            top++;
            elements[top] = newElement;
        }

        public void Pop()
        {
            if(top < 0)
            {
                Console.WriteLine("There are no elements in the stack");
                return;
            }

            top--;
        }

        public T Peek()
        {
            return elements[top]; 
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new StackEnumerator<T>(elements);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
