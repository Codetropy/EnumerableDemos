using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnumerableDemos
{
    public class MyList<T> : IEnumerable<T>
    {
        private T[] m_Items = null;
        private int freeIndex = 0;

        public MyList()
        {
            m_Items = new T[100];
        }

        public void Add(T item)
        {
            m_Items[freeIndex] = item;
            freeIndex++;
        }

        public IEnumerator<T> GetEnumerator ()
        {
            foreach (T t in m_Items)
            {
                // Lets check for end of list (its bad code since we used arrays)
                if (t == null) // this wont work is T is not a nullable type
                {
                    break;
                }

                // Return the current element and then on next function call 
                // resume from next element rather than starting all over again;
                yield return t;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator ()
        {
            // Lets call the generic version here
            return this.GetEnumerator();
        }

        
    }
}