using System;
using System.Collections.Generic;
using System.Text;

namespace ListsStacksQueues
{
    public class Node<T>
    {
        private T element;
        private Node<T> next;

        public T Element
        {
            get
            {
                return element;
            }
            set
            {
                element = value;
            }
        }

        public Node<T> Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }

        public Node(T element, Node<T> prevNode)
        {
            this.element = element;
            prevNode.next = this;
        }

        public Node (T element)
        {
            this.element = element;
            next = null;
        }
    }
}

