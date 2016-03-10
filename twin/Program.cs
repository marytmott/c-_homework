using System;

namespace ConsoleApplication
{
    /// Write the twin() method so that it performs as indicated in the comment. Your solution should not use arrays.
    /// <summary>
    /// Use your definition of linkedlist in this method
    /// twin() takes yourlinkedlist type and doubles its length by replacing each node
    /// with two consecutive nodes referencing the same item.
    /// For example, if the input list is [ 3 7 4 2 2 ], the
    /// output list is [ 3 3 7 7 4 4 2 2 2 2 ].
    /// IMPORTANT: Do not try to make new copies of the items themselves.
    /// Make new nodes but just copy the reference to the items
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // MyLinkedList linked = new MyLinkedList();
            // linked.Add(15);
            // linked.Add(23);
            // int testNode = linked.Head.Num;
            // int testNode2 = linked.Tail.Num;

            // // Console.WriteLine(linked.Length);
            // Console.WriteLine(testNode);
            // Console.WriteLine(testNode2);

            int[] nums = {3, 7, 4, 2, 2};
            MyLinkedList testList = new MyLinkedList();

            foreach(int num in nums)
            {
                testList.Add(num);
            }

            int origLength = testList.Length;
            Console.WriteLine(origLength);

            MyLinkedList.twin(testList);

            // int tailNum = testList.Tail.Num;
            // Console.WriteLine(tailNum);
        }
    }

    public class MyLinkedList
    {
        // fields
        Node head = null;
        Node tail = null;
        int length = 0;

        public Node Head
        {
            get
            {
                return head;
            }
            private set
            {
                head = value;
            }
        }

        public Node Tail
        {
            get
            {
                return tail;
            }
            private set
            {
                tail = value;
            }
        }

        public int Length
        {
            get
            {
                return length;
            }
            private set
            {
                length = value;
            }
        }

        // properties
        // these should be modifiable only by this class

        // does this need to be public or private or what??

        // add new val to node
        public Node Add(int num)
        {
            // new node
            Node newNode = new Node(num);
            length++;
            // if first node, set as head
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                tail.Next = newNode;
            }
            tail = newNode;
            return newNode;
        }

        // this should be a to string thang
        // just prints out the vals of the linked list
        public static void forEach(MyLinkedList list)
        {
            // to show list
            Node currNodeEach = list.Head;

            for (int i = 0; i < list.Length; i++)
            {
                int copyVal = currNodeEach.CopyOf.Num;
                int nodeVal = currNodeEach.Num;
                Console.WriteLine("_____________________________");
                Console.WriteLine("{0} points to Node Value: {1}", i, copyVal);
                Console.WriteLine("My value is: {0} (0 is false)", nodeVal);
                currNodeEach = currNodeEach.Next;
            }
        }

        /// Write the twin() method so that it performs as indicated in the comment. Your solution should not use arrays.
        /// <summary>
        /// Use your definition of linkedlist in this method
        /// twin() takes yourlinkedlist type and doubles its length by replacing each node
        /// with two consecutive nodes referencing the same item.
        /// For example, if the input list is [ 3 7 4 2 2 ], the
        /// output list is [ 3 3 7 7 4 4 2 2 2 2 ].
        /// IMPORTANT: Do not try to make new copies of the items themselves.
        /// Make new nodes but just copy the reference to the items
        /// </summary>
        public static void twin(MyLinkedList list)
        {

            // Fill in your solution here.
            Node currNode = list.Head;
            Node temp = null;
            int listLength = list.Length;

            // DRY UP!
            for (int i = 0; i < listLength; i += 2)
            {
                Node copy1 = new Node();
                Node copy2 = new Node();

                copy1.CopyOf = currNode;
                copy2.CopyOf = currNode;

                // check for head
                if (currNode != list.Head)
                {
                    temp.Next = copy1;
                }
                else
                {
                    list.Head = copy1;
                }

                copy1.Next = copy2;
                currNode = currNode.Next;
                temp = copy2;
                list.Length++;
                listLength = list.Length;
            }

            // set tail
            list.Tail = temp;

            MyLinkedList.forEach(list);
        }
    }

    public class Node
    {
        // fields
        int num;
        Node next = null;
        Node copyOf = null;

        // properties
        public int Num
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }

        public Node Next
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

        public Node CopyOf
        {
            get
            {
                return copyOf;
            }
            set
            {
                copyOf = value;
            }
        }
        // destructor -- TODO!
        // ~Node()
        // {

        // }

        // constructor
        public Node(int number)
        {
            num = number;
        }

        // OVERLoAD
        public Node()
        {
        }
    }
}
