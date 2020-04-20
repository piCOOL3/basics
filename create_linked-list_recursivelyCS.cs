using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_linked-list_recursively
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    class Program
    {
        public static ListNode create_linked_node(int[] arr_collection , int first_element , int last_element)
        {
            // create the list node and allocate the memory to the list node 

            ListNode root = null;

            if (first_element <= last_element)
            {
                 // iterating all the values in the arr collection until the collection  gets over
                // recursively create a new node 
                  root = new ListNode(arr_collection[first_element]);
                    // assign the memory to the newly created node 

                  root.next = create_linked_node(arr_collection, first_element + 1, last_element);
            }
            return root; 
        }
        public static ListNode build_linked_list(int[] arr_collection)
        {
            int front = arr_collection.GetLowerBound(0);
            int last  = arr_collection.GetUpperBound(0);
            // get the front_index and the last_index value 

            
            ListNode root = create_linked_node(arr_collection, front, last);
            //  function to create the linked list structure based on the input arr-collection

            return root;
        }

        public static void visit_linked_list(ListNode root)
        {
            // visit all the linked nodes present in the linked list iteratively 
            // if the node is null , return 
            // if the node contains a single node , print the node 

            ListNode temp_root = root;
            // donot disturb the root node 

            while (temp_root != null)
            {
                // if the node is not null , print the data pointed by the list node 
                Console.Write(temp_root.val + " ");
                temp_root = temp_root.next;
            }
        }
        static void Main(string[] args)
        {
            int[] arr_collection = new int[] { 1 , 2 , 3 , 4 };
            // given integer array containing the values of the node.

            ListNode root = null;
            // root element of the node 

            root = build_linked_list(arr_collection);
            // build the linked list node structure with the given data list 

            Console.WriteLine("the elements in the linked list are : ");
            visit_linked_list(root);
            // browse all the elements of the linked list iteratively 

            Console.ReadLine();

        }
    }
}
