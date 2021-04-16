using System;
using System.Collections.Generic;
using System.Text;

namespace ListsStacksQueues
{

    public class ArrayList<T>
    {
        private T[] arr;

        private int count;

        public int Count
        {
            get
            {
                return count;
            }
        }

        private static readonly int INITIAL_CAPACITY = 4;

        public ArrayList()
        {
            arr = new T[INITIAL_CAPACITY];
            count = 0;
        }

        public void Add(T item)
        {
            Insert(count, item);
        }

        public void Insert(int index, T item)
        {

            if (index > count || count < 0)
            {
                throw new IndexOutOfRangeException("Invalid Index: " + index);
            }

            T[] extendedArray = arr;

            if (count + 1 == arr.Length)
            {
                extendedArray = new T[arr.Length * 2];
            }

            Array.Copy(arr, extendedArray, index);         
            count++;
            Array.Copy(arr, index, extendedArray, index + 1, count - index - 1);
            extendedArray[index] = item;
            arr = extendedArray;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if ( item.Equals(arr[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Clear()
        {
            arr = new T[INITIAL_CAPACITY];
            count = 0;
        }

        public bool Contains(T item)
        {
            int index = IndexOf(item);
            bool found = (index != -1);

            return found;
        }

        public T this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid Index: " + index);
                }
                return arr[index];
            }
            set
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid Index: " + index);
                }
                arr[index] = value;
            }
        }

        public int Remove(T item)
        {
            int index = IndexOf(item);

            if (index == -1)
            {
                return index;
            }

            Array.Copy(arr, index + 1, arr, index, count - index - 1);
            count--;

            return index;
        }

    }
}
