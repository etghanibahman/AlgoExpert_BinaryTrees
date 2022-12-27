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

            var result = BranchSums(tree1);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static List<int> BranchSums(BinaryTree root)
        {
            //here we need to save result in global list.
            List<int> res = new List<int>();

            //main logic
            BranchSums(root, res);

            return res;
        }
        public static void BranchSums(BinaryTree root, List<int> res)
        {
            if (root == null)
            {
                return;
            }
            else if (root.left == null && root.right == null) {
                res.Add(root.value);
            }

            root = SumChildNodeWithParent(root);

            BranchSums(root.left, res);
            BranchSums(root.right,res);
        }

        public static BinaryTree SumChildNodeWithParent(BinaryTree root)
        {
            if (root.left != null)
            {
                root.left.value += root.value;
            }
            if (root.right != null)
            {
                root.right.value += root.value;
            }
            return root;
        }
    }
}
