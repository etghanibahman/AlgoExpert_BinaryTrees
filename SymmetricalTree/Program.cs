using SharedLogicTrees;
using System;


namespace SymmetricalTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Case__1
            BinaryTree tree1 = new BinaryTree(1);
            BinaryTree tree2 = new BinaryTree(2);
            BinaryTree tree3 = new BinaryTree(2);
            BinaryTree tree4 = new BinaryTree(3);
            BinaryTree tree5 = new BinaryTree(4);
            BinaryTree tree6 = new BinaryTree(4);
            BinaryTree tree7 = new BinaryTree(3);
            BinaryTree tree8 = new BinaryTree(5);
            BinaryTree tree9 = new BinaryTree(6);
            BinaryTree tree10 = new BinaryTree(6);
            BinaryTree tree11 = new BinaryTree(5);

            tree1.left = tree2;
            tree1.right = tree3;

            tree2.left = tree4;
            tree2.right = tree5;

            tree3.left = tree6;
            tree3.right = tree7;

            tree4.left = tree8;
            tree4.right = tree9;

            tree7.left = tree10;
            tree7.right = tree11;
            #endregion

            Helpers.PrintTree(tree1);
            Console.WriteLine($"is this tree Symmetrical : {SymmetricalTree(tree1)}");
        }

        public static bool SymmetricalTree(BinaryTree tree)
        {
            // Write your code here.
            return false;
        }
    }
}
