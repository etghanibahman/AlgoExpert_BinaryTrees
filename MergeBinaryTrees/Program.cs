using SharedLogicTrees;
using System;

namespace MergeBinaryTrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree1_1 = new BinaryTree(1);
            BinaryTree tree1_2 = new BinaryTree(3);
            BinaryTree tree1_3 = new BinaryTree(2);
            BinaryTree tree1_4 = new BinaryTree(7);
            BinaryTree tree1_5 = new BinaryTree(4);
            tree1_1.left = tree1_2;
            tree1_1.right = tree1_3;
            tree1_2.left = tree1_4;
            tree1_2.right = tree1_5;

            BinaryTree tree2_1 = new BinaryTree(1);
            BinaryTree tree2_2 = new BinaryTree(5);
            BinaryTree tree2_3 = new BinaryTree(9);
            BinaryTree tree2_4 = new BinaryTree(2);
            BinaryTree tree2_5 = new BinaryTree(7);
            BinaryTree tree2_6 = new BinaryTree(6);
            tree2_1.left = tree2_2;
            tree2_1.right = tree2_3;
            tree2_2.left = tree2_4;
            tree2_3.left = tree2_5;
            tree2_3.right = tree2_6;

            var result = MergeBinaryTrees(tree1_1, tree2_1);
            Helpers.PrintTree(result);
        }

        public static BinaryTree MergeBinaryTrees(BinaryTree tree1, BinaryTree tree2)
        {
            tree1.value += tree2.value;
            
            if (tree1.left != null && tree2.left != null)
            {
                MergeBinaryTrees(tree1.left, tree2.left);
            }
            if (tree1.right != null && tree2.right != null)
            {
                MergeBinaryTrees(tree1.right, tree2.right);
            }
            if (tree1.left == null && tree2.left != null)
            {
                tree1.left = tree2.left;
            }
            if (tree1.right == null && tree2.right != null)
            {
                tree1.right = tree2.right;
            }

            return tree1;
        }

        // This is an input class. Do not edit.
        //public class BinaryTree
        //{
        //    public int value;
        //    public BinaryTree left = null;
        //    public BinaryTree right = null;

        //    public BinaryTree(int value)
        //    {
        //        this.value = value;
        //    }
        //}



    }
}
