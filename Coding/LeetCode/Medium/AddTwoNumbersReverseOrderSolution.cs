//You are given two non-empty linked lists representing two non-negative integers.The digits are stored in order and each of their nodes contain a single digit.Add the two numbers and return it as a linked list.

//You may assume the two numbers do not contain any leading zero, except the number 0 itself.

//Example:

//Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
//Output: 8 -> 0 -> 7
//Explanation: 342 + 465 = 807.

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{    
    class AddTwoNumbersReverseOrderSolution
    {
        public void execute()
        {
            var l1 = new ListNode(2);            
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            var l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            AddTwoNumbers(l1, l2);
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {            
            var res = Calculate(l1,l2);
            return res;
        }

        private ListNode Calculate(ListNode l1, ListNode l2)
        {
            int carry=0;
            int sum = l1.val + l2.val + carry;
            carry = sum / 10;
            var rootNode = new ListNode(sum % 10);            
            rootNode.next = CalculateRecursively(l1.next, l2.next, carry);            
            return rootNode;
        }

        private ListNode CalculateRecursively(ListNode l1, ListNode l2, int carry)
        {
            if (l1 == null && l2 == null)
            {       
                if(carry != 0)
                {
                    return new ListNode(carry);
                }
                return null;
            }

            int sum = 0;
            var currentNode = new ListNode(0);
            if(l1 == null)
            {
                sum = 0 + l2.val + carry;
                carry = sum / 10;
                currentNode = new ListNode(sum % 10);
                currentNode.next = CalculateRecursively(l1, l2.next, carry);
            }
            else if(l2 == null)
            {
                sum = l1.val + 0 + carry;
                carry = sum / 10;
                currentNode = new ListNode(sum % 10);
                currentNode.next = CalculateRecursively(l1.next, l2, carry);
            }
            else
            {
                sum = l1.val + l2.val + carry;
                carry = sum / 10;
                currentNode = new ListNode(sum % 10);
                currentNode.next = CalculateRecursively(l1.next, l2.next, carry);
            }
            
            return currentNode;
        }
    }
}
