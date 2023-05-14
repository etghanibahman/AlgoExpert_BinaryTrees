using SharedLogicTrees;
using System;
using System.Collections.Generic;

namespace SymmetricalTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Case__1
            //BinaryTree tree1 = new BinaryTree(1);
            //BinaryTree tree2 = new BinaryTree(2);
            //BinaryTree tree3 = new BinaryTree(2);
            //BinaryTree tree4 = new BinaryTree(3);
            //BinaryTree tree5 = new BinaryTree(4);
            //BinaryTree tree6 = new BinaryTree(4);
            //BinaryTree tree7 = new BinaryTree(3);
            //BinaryTree tree8 = new BinaryTree(5);
            //BinaryTree tree9 = new BinaryTree(6);
            //BinaryTree tree10 = new BinaryTree(6);
            //BinaryTree tree11 = new BinaryTree(5);

            //tree1.left = tree2;
            //tree1.right = tree3;

            //tree2.left = tree4;
            //tree2.right = tree5;

            //tree3.left = tree6;
            //tree3.right = tree7;

            //tree4.left = tree8;
            //tree4.right = tree9;

            //tree7.left = tree10;
            //tree7.right = tree11;
            #endregion

            #region Case__2
            //BinaryTree tree1 = new BinaryTree(1);
            //BinaryTree tree2 = new BinaryTree(2);
            //tree1.left = tree2;
            //tree1.right = null;

            #endregion

            #region Case__6
            BinaryTree tree1 = new BinaryTree(1);
            BinaryTree tree2 = new BinaryTree(2);
            BinaryTree tree2_2 = new BinaryTree(2);
            BinaryTree tree3 = new BinaryTree(3);
            tree1.left = tree2;
            tree1.right = tree2_2;
            tree2.left = tree3;
            #endregion

            #region Case__12
            //BinaryTree tree1 = new BinaryTree(1);
            //BinaryTree tree2 = new BinaryTree(2);
            //BinaryTree tree2_2 = new BinaryTree(2);
            //BinaryTree tree3 = new BinaryTree(3);
            //BinaryTree tree3_2 = new BinaryTree(3);
            //BinaryTree tree4 = new BinaryTree(4);
            //BinaryTree tree4_2 = new BinaryTree(4);
            //BinaryTree tree5 = new BinaryTree(5);
            //tree1.left = tree2;
            //tree1.right = tree2_2;
            //tree2.left = tree3;
            //tree2.right = tree4;
            //tree2_2.left = tree4_2;
            //tree2_2.right = tree3_2;
            //tree4_2.right = tree5;
            #endregion

            Helpers.PrintTree(tree1);
            Console.WriteLine($"is this tree Symmetrical : {SymmetricalTree(tree1)}");
        }

        #region Recursive_Solution___O(n)_Time__O(h)_Space
        public static bool SymmetricalTree(BinaryTree tree)
        {
            if (tree == null)
            {
                return false;
            }
            return SymmetricalTreeHelper(tree.left, tree.right);
        }
        public static bool SymmetricalTreeHelper(BinaryTree leftTree, BinaryTree rightTree)
        {
            if (leftTree != null && rightTree != null)
            {
                if (leftTree.value == rightTree.value)
                {
                    return SymmetricalTreeHelper(leftTree.left, rightTree.right) && SymmetricalTreeHelper(rightTree.left, leftTree.right);
                }
            }
            else if(leftTree == null && rightTree == null)
            {
                return true;
            }
            return false;
        }
        #endregion


        #region My_Solution___O(n)_Time__O(h)_Space
        //public static bool SymmetricalTree(BinaryTree tree)
        //{
        //    if (tree.left == null && tree.right == null)
        //    {
        //        return true;
        //    }
        //    else if ((tree.left == null && tree.right != null) || (tree.left != null && tree.right == null))
        //    {
        //        return false;
        //    }
        //    var treeRight = tree.right;
        //    var treeLeft = tree.left;
        //    Stack<BinaryTree> stackRight = new Stack<BinaryTree>();
        //    Stack<BinaryTree> stackLeft = new Stack<BinaryTree>();
        //    if (treeLeft?.value != null)
        //        stackLeft.Push(treeLeft);
        //    if (treeRight?.value != null)
        //        stackRight.Push(treeRight);


        //    while (stackRight.Count > 0 || stackLeft.Count > 0)
        //    {
        //        var currentRight = stackRight.Count > 0 ? stackRight.Pop() : new BinaryTree(-1);
        //        var currentLeft = stackLeft.Count > 0 ? stackLeft.Pop() : new BinaryTree(-1);
        //        if (currentLeft.value != currentRight.value)
        //        {
        //            return false;
        //        }
        //        if (currentLeft.left != null)
        //        {
        //            stackLeft.Push(currentLeft.left);
        //        }
        //        if (currentLeft.right != null)
        //        {
        //            stackLeft.Push(currentLeft.right);
        //        }
        //        if (currentRight.right != null)
        //        {
        //            stackRight.Push(currentRight.right);
        //        }
        //        if (currentRight.left != null)
        //        {
        //            stackRight.Push(currentRight.left);
        //        }
        //    }
        //    return true;
        //}
        #endregion

    }
}
