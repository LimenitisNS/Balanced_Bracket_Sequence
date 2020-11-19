using System;
using System.Collections;
using System.Collections.Generic;

namespace Balanced_Bracket_Sequence
{
    class StackEnumerator<T> : IEnumerator<T>
    {
        public int top = -1;
        public T[] elements;

        public T Current
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

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public StackEnumerator(T[] newElements)
        {
            elements = newElements;
        }

        public bool MoveNext()
        {
            top++;
            return (top < elements.Length);
        }

        public void Reset()
        {
            top--;
        }

        public void Dispose()
        {

        }
    }
}
