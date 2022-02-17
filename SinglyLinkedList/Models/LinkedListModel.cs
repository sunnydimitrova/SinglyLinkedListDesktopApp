using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList.Models
{
    public class LinkedListModel
    {
        private Node head;

        private class Node
        {
            internal int data;
            internal Node next;
            internal Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }

        public void Add(int element)
        {
            var node = new Node(element);
            node.next = this.head;
            this.head = node;
        }

        public string ReturnMthFromLast(int m)
        {
            var pointer = this.head;

            if (pointer != null && m >= 0)
            {
                if (m == 0)
                {
                    return pointer.data.ToString();
                }
                for (int i = 0; i < m; i++)
                {
                    if (pointer.next != null)
                    {
                        pointer = pointer.next;
                    }
                    else
                    {
                        return "Invalid M.";
                    }
                }

                return pointer.data.ToString();
            }
            else
            {
                return "Invalid data.";
            }
        }

        public bool IsEmpty() => head == null;
       
    }
}
