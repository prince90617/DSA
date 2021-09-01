using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA
{
    public class PreOrderTraversal
    {
        public PreOrderTraversal()
        {

        }
        public IList<int> PreOrderTraversalOfTreeNodes(TreeNode root)
        {
            Stack<TreeNode> treeNodes = new Stack<TreeNode>();
            List<int> result = new List<int>();

            if (root == null)
                return result;

            treeNodes.Push(root);
            while (treeNodes.Any())
            {
                TreeNode node = treeNodes.Pop();

                result.Add(node.Val);

                if (node.Right != null) treeNodes.Push(node.Right);
                if (node.Left != null) treeNodes.Push(node.Left);
            }
            return result;
        }
    }
}
