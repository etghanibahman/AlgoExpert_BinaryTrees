using System;
using System.Collections.Generic;
using System.Linq;

namespace InvertBinaryTree
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

            tree1.left = tree2;
            tree1.right = tree3;

            tree2.left = tree4;
            tree2.right = tree5;

            tree3.left = tree6;
            tree3.right = tree7;

            tree4.left = tree8;
            tree4.right = tree9;

            tree5.left = null;
            tree5.right = null;

            tree6.left = null;
            tree6.right = null;

            tree7.left = null;
            tree7.right = null;
            #endregion
            //Console.WriteLine("Hello World!");
            PrintTree(tree1);
            InvertBinaryTree(tree1);
            PrintTree(tree1);
        }

        #region By__Queue
        //public static void InvertBinaryTree(BinaryTree tree)
        //{
        //    var q = new Queue<BinaryTree>();
        //    q.Enqueue(tree);

        //    while (q.Count > 0)
        //    {
        //        var currentNode = q.Dequeue();

        //        if (currentNode == null)
        //            continue;

        //        var temp = currentNode.left;
        //        currentNode.left = currentNode.right;
        //        currentNode.right = temp;

        //        q.Enqueue((currentNode.left));
        //        q.Enqueue((currentNode.right));
        //    }
        //}
        #endregion

        #region Recursive
        public static void InvertBinaryTree(BinaryTree tree)
        {
            if (tree == null)
                return;

            var temp = tree.left;
            tree.left = tree.right;
            tree.right = temp;

            InvertBinaryTree(tree.left);
            InvertBinaryTree(tree.right);
        }
        #endregion


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
