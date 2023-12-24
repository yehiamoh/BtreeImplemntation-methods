using System.Security.Cryptography;

namespace binaryTree
{
    class Node
    {
        public int data;
        public Node right;
        public Node left;
        public Node(int data)
        {
            this.data = data;
        }

    }
    class BinarySearchTree
    {
        public Node root;
        /*
        travesal => inorder,preorder,postorder
       Inorder Traversal.LNR
       Preorder Traversal.NLR
       PostOrder Traversal.LRN
        */

        public void inOrder()
        {
            inOrder(root);
        }
        void inOrder(Node node)
        {

            if (node != null)
            {
                inOrder(node.left);
                Console.WriteLine(node.data + " ");
                inOrder(node.right);
            }
        }

        public void preOrder()
        {
            preOrder(root);
        }
        void preOrder(Node node)
        {
            if (node != null)
            {
                Console.WriteLine(node.data + " ");
                preOrder(node.left);
                preOrder(node.right);
            }

        }

        public void postOrder()
        {
            postorder(root);
        }
        void postorder(Node node)
        {
            if (node != null)
            {
                postorder(node.left);
                postorder(node.right);
                Console.WriteLine(node.data + "  ");
            }
        }
        public Node searchRecursivly(int x)
        {
            return searchRecursivly(root, x);
        }
        public Node searchIterative(int x)
        {
            return searchItreative(root, x);
        }
        Node searchItreative(Node node, int x)
        {
            Node p = node;
            while (p != null)
            {
                if (p.data > x)
                {
                    p = p.left;
                }
                else if (p.data < x)
                {
                    p = p.right;
                }
                else
                    return p;
            }
            return null;
        }
        Node searchRecursivly(Node node, int x)
        {
            Node p = node;
            if (p == null)
            {
                return p;
            }
            if (p.data < x)
            {
                searchRecursivly(p.right, x);
            }
            if (p.data > x)
            {
                searchRecursivly(p.left, x);
            }
            return p;
        }

        Node getMinIterative(Node p)
        {

            if (p == null)
            {
                return null;
            }
            while (p != null)
            {
                p = p.left;
            }
            return p;
        }
        Node getMaxIterative(Node p)
        {
            if (p == null)
            {
                return p;
            }
            while (p != null)
            {
                p = p.right;
            }
            return p;
        }
        Node getMaxRecursivly(Node p)
        {
            if (p == null)
            {
                return null;
            }
            if (p.right == null)
            {
                return p;
            }
            return getMaxRecursivly(p.right);
        }
        Node getMinRecursivly(Node p)
        {
            if (p == null)
            {
                return null;
            }
            if (p.left == null)
            {
                return p;
            }
            return getMinRecursivly(p.left);
        }







    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FUCK MAN UTD");

        }
    }
}
