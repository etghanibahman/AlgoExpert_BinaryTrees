using System;
using System.Collections.Generic;
using System.Linq;

namespace FindSuccessorProject
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

            tree1.left = tree2;
            tree1.right = tree3;
            tree1.parent = null;

            tree2.left = tree4;
            tree2.right = tree5;
            tree2.parent = tree1;

            tree3.left = null;
            tree3.right = null;
            tree3.parent = tree1;

            tree4.left = tree6;
            tree4.right = null;
            tree4.parent = tree2;

            tree5.left = null;
            tree5.right = null;
            tree5.parent = tree2;

            tree6.left = null;
            tree6.right = null;
            tree6.parent = tree4;
            #endregion

            var result = FindSuccessor(tree1, tree5);
            if (result != null)
                Console.WriteLine($"Successor's value is : {result.value}");
            else
                Console.WriteLine($"Successor is not found!");
        }

        // This is an input class. Do not edit.
        public class BinaryTree
        {
            public int value;
            public BinaryTree left = null;
            public BinaryTree right = null;
            public BinaryTree parent = null;

            public BinaryTree(int value)
            {
                this.value = value;
            }
        }


        //This one works when we have parent node, if not we have no choice but to go for traversing the whole tree
        #region O(h) Time, O(1) Space
        //public static BinaryTree FindSuccessor(BinaryTree tree, BinaryTree node)
        //{
        //    if (node.right != null)
        //        return GetLeftMostChild(node.right);

        //    return GetRightMostParent(node);
        //}

        //public static BinaryTree GetLeftMostChild(BinaryTree node)
        //{
        //    while (node.left != null)
        //    {
        //        node = node.left;
        //    }
        //    return node;
        //}
        //public static BinaryTree GetRightMostParent(BinaryTree node)
        //{
        //    while (node.parent != null && node.parent.right == node)
        //    {
        //        node = node.parent;
        //    }
        //    return node.parent;
        //}
        #endregion

        #region O(n) Time, O(n) Space
        public static BinaryTree FindSuccessor(BinaryTree tree, BinaryTree node)
        {
            var inOrderTraversalOrder = getInOrderTraversalOrder(tree);

            foreach (var item in inOrderTraversalOrder)
            {
                if (item == node)
                {
                    var idx = inOrderTraversalOrder.IndexOf(item);
                    if (idx != inOrderTraversalOrder.Count - 1)
                    {
                        return inOrderTraversalOrder.ElementAt(idx + 1);
                    }
                    continue;
                }
            }

            return null;
        }

        public static List<BinaryTree> lstNodes = new List<BinaryTree>();
        public static List<BinaryTree> getInOrderTraversalOrder(BinaryTree node)
        {
            if (node == null)
                return lstNodes;

            getInOrderTraversalOrder(node.left);
            lstNodes.Add(node);
            getInOrderTraversalOrder(node.right);

            return lstNodes;
        }
        #endregion
    }
}