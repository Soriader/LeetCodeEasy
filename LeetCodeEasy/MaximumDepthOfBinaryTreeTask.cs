namespace LeetCodeEasy;

public class MaximumDepthOfBinaryTreeTask
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
    
        int maxDepth = 0;
        var stack = new Stack<(TreeNode Node, int Depth)>();
        stack.Push((root, 1));
    
        while (stack.Count > 0)
        {
            var (current, depth) = stack.Pop();
            maxDepth = Math.Max(maxDepth, depth);
        
            if (current.right != null)
            {
                stack.Push((current.right, depth + 1));
            }
            if (current.left != null)
            {
                stack.Push((current.left, depth + 1));
            }
        }
    
        return maxDepth;
    }
}
//https://leetcode.com/problems/maximum-depth-of-binary-tree/description/



/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */