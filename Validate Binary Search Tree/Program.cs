using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validate_Binary_Search_Tree
{
    class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        static void Main(string[] args)
        {
        }

        static bool IsValidBST(TreeNode root)
        {
            Stack<TreeNode> stk = new Stack<TreeNode>();
            TreeNode previous = null;
            while(root != null || stk.Count > 0)
            {
                while(root != null)
                {
                    stk.Push(root);
                    root = root.left;
                }
                root = stk.Pop();
                if (previous != null && root.val <= previous.val) return false;
                previous = root;
                root = root.right;
            }
            return true;
        }
    }
}
