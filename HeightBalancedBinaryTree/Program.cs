using System;
using System.Collections.Generic;

namespace HeightBalancedBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Test Case 1
            //BinaryTree tree1 = new BinaryTree(1);
            //BinaryTree tree2 = new BinaryTree(2);
            //BinaryTree tree3 = new BinaryTree(3);
            //BinaryTree tree4 = new BinaryTree(4);
            //BinaryTree tree5 = new BinaryTree(5);
            //BinaryTree tree6 = new BinaryTree(6);
            //BinaryTree tree7 = new BinaryTree(7);
            //BinaryTree tree8 = new BinaryTree(7);

            //tree1.left = tree2;
            //tree1.right = tree3;
            //tree2.left = tree4;
            //tree2.right = tree5;
            //tree3.right = tree6;
            //tree5.left = tree7;
            //tree5.right = tree8;
            #endregion

            #region Test Case 11
            BinaryTree tree1 = new BinaryTree(1);
            BinaryTree tree2 = new BinaryTree(2);
            BinaryTree tree3 = new BinaryTree(3);

            tree1.left = tree2;
            tree1.right = null;
            tree2.left = null;
            tree2.right = tree3;
            tree3.left = null;
            tree3.right = null;

            #endregion

            Console.WriteLine($"Is it a balanced Tree? { HeightBalancedBinaryTree(tree1) }");
        }

        static bool isBalanced = true;
        public static bool HeightBalancedBinaryTree(BinaryTree tree)
        {
            CalculateHeightBalancedBinaryTree(tree);
            return isBalanced;
        }

        public static int CalculateHeightBalancedBinaryTree(BinaryTree tree) {
            if (isBalanced)
            {
                if (tree.left == null && tree.right == null)
                {
                    return 0;
                }
                var leftHeight = tree.left != null ? CalculateHeightBalancedBinaryTree(tree.left) + 1 : 0;
                var rightHeight = tree.right != null ? CalculateHeightBalancedBinaryTree(tree.right) + 1 : 0;
                if (isBalanced && Math.Abs(leftHeight - rightHeight) > 1)
                {
                    isBalanced = false;
                }
                var height = Math.Max(leftHeight,rightHeight);
                return height;
            }
            return 0;
        }

        #region my Solution
                //public static bool HeightBalancedBinaryTree(BinaryTree tree)
                //{
                //	Stack<BinaryTree> stackNodes = new Stack<BinaryTree>();
                //	List<(int NodeValue, int leftHeight, int rightHeight)> nodeDepths= new List<(int NodeValue, int leftHeight, int rightHeight)>();
                //	stackNodes.Push(tree);
                //          while (stackNodes.Count>0)
                //          {
                //		var currentNode = stackNodes.Pop();
                //		var leftDepth = (currentNode.left != null) ? NodeDepths(currentNode.left) : 0;
                //		var righttDepth = (currentNode.right != null) ? NodeDepths(currentNode.right) : 0;
                //		nodeDepths.Add((currentNode.value,leftDepth,righttDepth));
                //              if (currentNode.left != null)
                //              {
                //			stackNodes.Push(currentNode.left);
                //              }
                //              if (currentNode.right != null)
                //              {
                //			stackNodes.Push(currentNode.right);
                //              }
                //          }

                //          foreach (var item in nodeDepths)
                //          {
                //              if (Math.Abs(item.leftHeight - item.rightHeight) > 1)
                //              {
                //			return false;
                //              }
                //          }
                //	return true;
                //}

                //public static int NodeDepths(BinaryTree root)
                //{
                //	var res = 0;
                //	var queue = new Queue<BinaryTree>();
                //	if (root != null) queue.Enqueue(root);

                //	while (queue.Count > 0)
                //	{
                //		var size = queue.Count;
                //		res++;
                //		for (int i = 0; i < size; i++)
                //		{
                //			var top = queue.Dequeue();

                //			if (top.left != null)
                //			{
                //				queue.Enqueue(top.left);
                //			}

                //			if (top.right != null)
                //			{
                //				queue.Enqueue(top.right);
                //			}
                //		}
                //	}
                //	return res;
                //}
                #endregion

        public class BinaryTree
		{
			public int value;
			public BinaryTree left = null;
			public BinaryTree right = null;

			public BinaryTree(int value)
			{
				this.value = value;
			}
		}

		
	}
}
