using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.String
{  
     public class TreeNode {
         public int val;
         public TreeNode left;
         public TreeNode right;
         public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
             this.val = val;
             this.left = left;
             this.right = right;
         }
     }
 
    public class Tree2strSoln
    {
        public string Tree2str(TreeNode t)
        {
            if (t == null) return "";
            var str = new StringBuilder();
            str.Append(t.val);
            if (t.left != null)
            {
                str.Append("(");
                str.Append(Tree2str(t.left));
                str.Append(")");
            }
            if(t.right != null)
            {
                if(t.left == null)
                {
                    str.Append("()");                    
                }

                str.Append("(");
                str.Append(Tree2str(t.right));
                str.Append(")");
            }
            return str.ToString();
        }
    }
}
