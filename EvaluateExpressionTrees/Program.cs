using System;

namespace EvaluateExpressionTrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree1 = new BinaryTree(-1);
            BinaryTree tree2 = new BinaryTree(-2);
            BinaryTree tree3 = new BinaryTree(-3);
            BinaryTree tree4 = new BinaryTree(-4);
            BinaryTree tree5 = new BinaryTree(2);
            BinaryTree tree6 = new BinaryTree(8);
            BinaryTree tree7 = new BinaryTree(3);
            BinaryTree tree8 = new BinaryTree(2);
            BinaryTree tree9 = new BinaryTree(3);

            tree1.left = tree2;
            tree1.right = tree3;
            tree2.left = tree4;
            tree2.right = tree5;
            tree3.left = tree6;
            tree3.right = tree7;
            tree4.left = tree8;
            tree4.right = tree9;

            Console.WriteLine($"The evaluation of the tree is : {EvaluateExpressionTree(tree1)}");
        }

        //O(n) Time / O(h) space
        public static int EvaluateExpressionTree(BinaryTree tree)
        {
            if (tree.value >= 0)
                return tree.value;

            int leftValue = EvaluateExpressionTree(tree.left);
            int rightValue = EvaluateExpressionTree(tree.right);

            switch (tree.value)
            {
                case -1:
                    return leftValue + rightValue;
                case -2:
                    return leftValue - rightValue;
                case -3:
                    return leftValue / rightValue;
                default:
                    return leftValue * rightValue;
            }
        }
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
