using SharedLogicTrees;
using System;
using System.Collections.Generic;

namespace BranchSums
{
    class Program
    {
        static void Main(string[] args)
        {
			//We're supposed to return back a list of sum of branchs in a tree;

			BinaryTree tree1 = new BinaryTree(1);
			BinaryTree tree2 = new BinaryTree(2);
			BinaryTree tree3 = new BinaryTree(3);
			BinaryTree tree4 = new BinaryTree(4);
			BinaryTree tree5 = new BinaryTree(5);
			BinaryTree tree6 = new BinaryTree(6);
			BinaryTree tree7 = new BinaryTree(7);

			tree1.left = tree2;
			tree1.right = tree3;
			tree2.left = tree4;
			tree2.right = tree5;
			tree3.left = tree6;
			tree3.right = tree7;

			Helpers.PrintTree(tree1);
		}

		public static List<int> BranchSums(BinaryTree root)
		{
			// Write your code here.
			return new List<int>();
		}
	}
}
