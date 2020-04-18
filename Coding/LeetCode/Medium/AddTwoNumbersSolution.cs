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
    
    //Definition for singly-linked list.
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    
    class AddTwoNumbersSolution
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
            var res = new ListNode(0);
            int len1 = FindLength(l1);
            int len2 = FindLength(l2);
            int diff1 = 0;
            int diff2 = 0;
            if (len1 > len2)
            {
                diff1 = len1 - len2;
                while(diff1 != 0)
                {
                    var temp = new ListNode(0);
                    temp.next = l2;
                    l2 = temp;
                }
            }
            else
            {
                diff2 = len2 - len1;
                while (diff2 != 0)
                {
                    var temp = new ListNode(0);
                    temp.next = l1;
                    l1 = temp;
                }
            }

            res = Calculate(l1,l2);
            return res;
        }

        private ListNode Calculate(ListNode l1, ListNode l2)
        {
            int carry=0;
            var node = CalculateRecursively(l1, l2, ref carry);
            if(carry == 1)
            {
                var temp = new ListNode(carry);
                temp.next = node;
                node = temp;
            }
            return node;
        }

        private ListNode CalculateRecursively(ListNode l1, ListNode l2, ref int carry)
        {
            if (l1 == null)
            {
                carry = 0;
                return null;
            }

            var node = CalculateRecursively(l1.next, l2.next, ref carry);
            int sum = l1.val + l2.val +carry;
            carry = sum / 10;
            var currentNode = new ListNode(sum % 10);
            currentNode.next = node;
            return currentNode;
        }

        private int FindLength(ListNode l1)
        {
            int len = 0;
            //ListNode temp = l1;
            while(l1 != null)
            {
                len++;
                l1 = l1.next;
            }
            return len;
        }
    }
}
