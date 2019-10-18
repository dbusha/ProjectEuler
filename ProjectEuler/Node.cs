using System.Runtime.CompilerServices;

namespace ProjectEuler
{
    public class Node
    {
        public Node Parent { get; protected set; }
        public int LeafCount { get; protected set; }
    }

    public class BinaryTreeNode : Node
    {
        public BinaryTreeNode Left { get; protected set; }
        public BinaryTreeNode Right { get; protected set; }
        
        
        public void Add(BinaryTreeNode parent, int right, int left)
        {
            Parent = parent;
            if (right > 0)
            {
                Right = new BinaryTreeNode();
                Right.Add(this, right - 1, left);
            }

            if (left > 0)
            {
                Left = new BinaryTreeNode();
                Left.Add(this, right, left - 1);
            }

            if (right == 0 && left == 0)
                LeafCount = 1;
            LeafCount += (Left?.LeafCount ?? 0) + (Right?.LeafCount ?? 0);
        }


        public int GetLeafCount()
        {
            return LeafCount;
        }
        
    }
}