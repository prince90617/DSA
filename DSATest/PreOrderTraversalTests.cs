using System.Collections.Generic;
using DSA;
using Xunit;

namespace DSATest
{
    public class PreOrderTraversalTests
    {
        [Fact]
        public void ShouldReturnExpectedResultWhenPassValdParameters()
        {
            IList<int> expected = new List<int>() { 5, 3, 2, 1, 4 };
            TreeNode nodes = new TreeNode()
            {
                Val = 5,
                Left = new TreeNode()
                {
                    Val = 3,
                    Left = new TreeNode
                    {
                        Val = 2,
                        Left = new TreeNode()
                        {
                            Val = 1
                        }
                    },
                    Right = new TreeNode()
                    {
                        Val = 4
                    }
                },
                Right = null
            };
            PreOrderTraversal preOrder = new();

           IList<int> list = preOrder.PreOrderTraversalOfTreeNodes(nodes);

            Assert.Equal(expected, list);
        }
    }
}
