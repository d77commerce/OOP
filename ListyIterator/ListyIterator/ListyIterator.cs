using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> :IEnumerable<T>
    {
        private List<T> collection;
        private int index;

        public ListyIterator(params T[] ts)
        {
           collection = new List<T>(ts);
            index = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T element in collection)
            {
                yield return element;
            }
        }
        public void PrintAll()
        {
            Console.WriteLine(string.Join(" ",collection));
        }

        public bool HasNext()
        {
            return index < collection.Count - 1;
        }
        public bool Move()
        {
            if (index < collection.Count - 1)
            {
                index++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Print()
        {
            if (collection.Count == 0)
            {
                throw new ArgumentException ("Invalid Operation!");
            }
            Console.WriteLine($"{collection[index]}");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
