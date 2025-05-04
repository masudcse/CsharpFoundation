using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcersiceLinkedList
{
    public class Node
    {
        public object data = null;
        public Node next = null;
    }
    public class Node<AnyType>
    {
        public AnyType data;
        public Node<AnyType> next;
    }
    public class SampleLinkedList
    {
        Node head = null;
        public void AddLast(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            if (head == null)
            {

                head = newItem;
                head.next = null;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newItem;
                newItem.next = null;
            }
        }
        public void AddFirst(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            newItem.next = head;
            head = newItem;
        }
        public void ReadAll()
        {
            Node current = head;
            while (current.next != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
                
            }
            Console.WriteLine(current.data);
        }
        public void RemoveLast(object data)
        {
            Node current = head;
            while (current != null)
            {
                current = current.next;
            }

        }
    }
    public class SampleLinkedListTail
    {
        Node head = null;
        Node tail = null;
        public void AddLast(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            if (head == null)
            {

                head = newItem;
                tail = newItem;
            }
            else
            {
                tail.next = newItem;
                tail = newItem;
            }
        }
        public void AddFirst(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            if (head == null)
            {
                head=newItem;
                tail = newItem;
            }
            else
            {
                newItem.next = head;
                head = newItem;
            }
          
        }
        public void ReadAll()
        {
            Node current = head;
            while (current.next != null)
            {
                Console.WriteLine(current.data);
                current = current.next;

            }
            Console.WriteLine(current.data);
        }
        public void RemoveLast(object data)
        {
            Node current = head;
            while (current != null)
            {
                current = current.next;
            }

        }
    }
    public class SampleLinkedListGeneric<AnyType>
    {
        Node<AnyType> head = null;
        Node<AnyType> tail = null;
        public void AddLast(AnyType data)
        {
            Node<AnyType> newItem = new Node<AnyType>();
            newItem.data = data;
            if (head == null)
            {

                head = newItem;
                tail = newItem;
            }
            else
            {
                tail.next = newItem;
                tail = newItem;
            }
        }
        public void AddFirst(AnyType data)
        {
            Node<AnyType> newItem = new Node<AnyType>();
            newItem.data = data;
            if (head == null)
            {
                head = newItem;
                tail = newItem;
            }
            else
            {
                newItem.next = head;
                head = newItem;
            }

        }
        public void ReadAll()
        {
            Node<AnyType> current = head;
            while (current.next != null)
            {
                Console.Write($"{current.data}->");
                current = current.next;

            }
            Console.WriteLine(current.data);
        }
        public void ReverseReadAll()
        {
            Node<AnyType> current = head;
            Node<AnyType> prev=null;
            Node<AnyType> next=null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            Node<AnyType> temp = prev;
            while (temp != null)
            {
                Console.Write($"{temp.data}->");
                temp=temp.next;
            }
            Console.WriteLine("Null");
        }
        public void RemoveLast(AnyType data)
        {
            Node<AnyType> newItem = new Node<AnyType>();
            newItem.data = data;
            Node<AnyType> current = head;
            while (current.next.next != null)
            {
                current = current.next;
            }
            current.next = null;
        }
    }
}
