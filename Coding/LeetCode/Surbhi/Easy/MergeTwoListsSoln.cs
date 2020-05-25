using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Surbhi.Easy
{    
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }
    
    public class MergeTwoListsSoln
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode root = null;
            ListNode temp = null;
            while(l1 != null && l2 != null)
            {
                if (temp == null)
                {
                    temp = l1;
                    root = temp;
                   
                }
                else
                {
                    temp.next = l1;
                }
                if (l1 != null)
                    l1 = l1.next;
                else
                    temp = l1;
                temp.next = l2;
                if (l2 != null)
                    l2 = l2.next;
                else
                    temp = l2;
                
            }
            
            return root;
        }
    }
}
