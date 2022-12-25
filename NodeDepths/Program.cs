﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace NodeDepths
{
    class Program
    {
        static void Main(string[] args)
        {
			//We're supposed to return back sum of nodes' deptgh in a tree;

			BinaryTree tree1 = new BinaryTree(1);
			BinaryTree tree2 = new BinaryTree(2);
			BinaryTree tree3 = new BinaryTree(3);
			BinaryTree tree4 = new BinaryTree(4);
			BinaryTree tree5 = new BinaryTree(5);

			tree1.left = tree2;
			tree1.right = tree3;
			tree2.left = tree4;
			tree2.right = tree5;

			Console.WriteLine("We're supposed to return back sum of nodes' deptgh in a tree");
			PrintTree(tree1);
			Console.WriteLine($"The lentgh of the tree is :{NodeDepths(tree1) }");
		}


		public static int NodeDepths(BinaryTree root)
		{
			var q = new Queue<(BinaryTree node, int depth)>();
			q.Enqueue((root, 0));
			int totalDepth = 0;


            while (q.Count > 0)
            {
				var currentNode = q.Dequeue();
				var currentDepth = currentNode.depth + 1;

				if (currentNode.node.left != null)
                {
					q.Enqueue((currentNode.node.left, currentDepth));
					totalDepth += currentDepth;
                }
				if (currentNode.node.right != null)
				{
					q.Enqueue((currentNode.node.right, currentDepth));
					totalDepth += currentDepth;
				}
			}

			return totalDepth;
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
                if (i>0)
                {
					Console.WriteLine("|");
                }

				Console.WriteLine(string.Join('-',nodesValueDepth.Where(a => a.Value == i).Select(a => a.Key ).ToList()));

            }

		}



		//public static int NodeDepths(BinaryTree root)
		//{
		//	// Write your code here.
		//	return nodeDepthHelper(root, 0);
		//}

		//public static int nodeDepthHelper(BinaryTree root, int depth)
		//{
		//	if (root == null) return 0;
		//	return depth +
		//		nodeDepthHelper(root.left, depth + 1) + nodeDepthHelper(root.right, depth + 1);
		//}

		public class BinaryTree
		{
			public int value;
			public BinaryTree left;
			public BinaryTree right;

			public BinaryTree(int value)
			{
				this.value = value;
				left = null;
				right = null;
			}
		}
	}
}