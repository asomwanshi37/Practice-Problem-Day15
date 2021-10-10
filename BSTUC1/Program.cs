using System;

namespace BinaryTreeSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(1);
            binaryTree.Add(2);
            binaryTree.Add(3);
            binaryTree.Add(7);
            binaryTree.TravarsePreorder(binaryTree.Root);
            
        }
    }
}
