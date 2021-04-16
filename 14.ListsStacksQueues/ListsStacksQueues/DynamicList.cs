using System;
using System.Collections.Generic;
using System.Text;

namespace ListsStacksQueues
{
    public class DynamicList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int count = 0;

        //public DynamicList()
        //{
        //    //this.head = null;
        //    //this.tail = null;
        //    //this.count = 0;
        //}

        public void Add(T item)
        {
            if (head == null)
            {
                head = new Node<T>(item);
                tail = head;
            }
            else
            {
                Node<T> newNode = new Node<T>(item, tail);
                tail = newNode;
            }
            count++;
        }

        public T Remove(int index)
        {
            if (index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index: " + index);
            }
            int currentIndex = 0;
            Node<T> currentNode = head;
            Node<T> prevNode = null;

            while (currentIndex < index)
            {
                prevNode = currentNode;
                currentNode = currentNode.Next;
                currentIndex++;
            }
            count--;

            if (count == 0)
            {
                head = null;
            }
            else if (prevNode == null)
            {
                head = currentNode.Next;
            }
            else
            {
                prevNode.Next = currentNode.Next;
            }

            Node<T> lastElement = null;

            if (this.head != null)
            {
                lastElement = this.head;

                while (lastElement.Next != null)
                {
                    lastElement = lastElement.Next;
                }
            }
            tail = lastElement;

            return currentNode.Element;
        }

        public int Remove(object item)
        {
            int currentIndex = 0;
            Node<T> currentNode = head;
            Node<T> prevNode = null;

            while (currentNode != null)
            {

                if ((currentNode.Element != null && currentNode.Element.Equals(item)) || (currentNode.Element == null) && (item == null))
                {
                    break;
                }

                prevNode = currentNode;
                currentNode = currentNode.Next;
                currentIndex++;
            }

            if (currentNode != null)
            {
                count--;

                if (count == 0)
                {
                    head = null;
                }
                else if (prevNode == null)
                {
                    head = currentNode.Next;
                }
                else
                {
                    prevNode.Next = currentNode.Next;
                }

                Node<T> lastElement = null;
                if (this.head != null)
                {
                    lastElement = this.head;
                    while (lastElement.Next != null)
                    {
                        lastElement = lastElement.Next;
                    }
                }

                tail = lastElement;
                return currentIndex;
            }
            else
            {
                return -1;
            }

        }

        public int IndexOf(T item)
        {
            int index = 0;
            Node<T> current = head;

            while (current != null)
            {

                if ((current.Element != null && current.Element.Equals(item)) || (current.Element == null) && (item == null))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1;
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
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);
                }

                Node<T> currentNode = this.head;

                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }
                return currentNode.Element;
            }
            set
            {

                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);
                }

                Node<T> currentNode = this.head;

                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Element = value;
            }

        }

        //public void Print(T item)
        //{
        //    for (int i = 0; i < Count; i++)
        //    {
        //        item = head;
        //        Console.WriteLine( item);
        //        head = tail;
        //    }
        //}

        public int Count
        {
            get
            {
                return count;
            }
        }
    }
}
