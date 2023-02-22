using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryTreeDiameter
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Case__1
            BinaryTree tree1 = new BinaryTree(1);
            BinaryTree tree2 = new BinaryTree(2);
            BinaryTree tree3 = new BinaryTree(3);
            BinaryTree tree4 = new BinaryTree(4);
            BinaryTree tree5 = new BinaryTree(5);
            BinaryTree tree6 = new BinaryTree(6);
            BinaryTree tree7 = new BinaryTree(7);
            BinaryTree tree8 = new BinaryTree(8);
            BinaryTree tree9 = new BinaryTree(9);

            tree1.left = tree3;
            tree1.right = tree2;

            tree2.left = null;
            tree2.right = null;

            tree3.left = tree7;
            tree3.right = tree4;

            tree4.left = null;
            tree4.right = tree5;

            tree5.left = null;
            tree5.right = tree6;

            tree6.left = null;
            tree6.right = null;

            tree7.left = tree8;
            tree7.right = null;

            tree8.left = tree9;
            tree8.right = null;

            tree9.left = null;
            tree9.right = null;
			#endregion

			PrintTree(tree1);
			//Console.WriteLine("Hello World!");
		}

		public static int BinaryTreeDiameter(BinaryTree tree)
		{
			// Write your code here.
			return -1;
		}

		public class BinaryTree
		{
			public int value;
			public BinaryTree left;
			public BinaryTree right;

			public BinaryTree(int value)
			{
				this.value = value;
			}
		}

		public static void PrintTree(BinaryTree root)
		{
			var q = new Queue<(BinaryTree node, int depth)>();
			q.Enqueue((root, 0));
			Dictionary<int, int> nodesValueDepth = new Dictionary<int, int>();

			while (q.Count > 0)
			{
				var currentNode = q.Dequeue();
				var currentDepth = currentNode.depth + 1;
				nodesValueDepth.Add(currentNode.node.value, currentNode.depth);
				if (currentNode.node.left != null)
				{
					q.Enqueue((currentNode.node.left, currentDepth));
				}
				if (currentNode.node.right != null)
				{
					q.Enqueue((currentNode.node.right, currentDepth));
				}
			}

			var maxDepth = nodesValueDepth.Values.Max();
			for (int i = 0; i <= maxDepth; i++)
			{
				if (i > 0)
				{
					Console.WriteLine("|");
				}
				Console.WriteLine(string.Join('-', nodesValueDepth.Where(a => a.Value == i).Select(a => a.Key).ToList()));
			}
		}
	}
}
