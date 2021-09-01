using System;
using System.Linq;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode treeNode = new() {
                Val = 1,
                Left = new TreeNode()
                {
                    Val = 2,
                    Left = null,
                    Right = null
                },
                Right = new TreeNode
                {
                    Val = 3,
                    Left = new TreeNode()
                    {
                        Val = 4,
                        Left = null,
                        Right = null
                    },
                    Right = null
                     
                 }
            };
            PreOrderTraversal preOrderTraversal = new PreOrderTraversal();
            Console.WriteLine("Pre-Order traversal : {0}", String.Join(",", preOrderTraversal.PreOrderTraversalOfTreeNodes(treeNode).Select(x=> x.ToString()).ToArray()));
        }
    }
}
