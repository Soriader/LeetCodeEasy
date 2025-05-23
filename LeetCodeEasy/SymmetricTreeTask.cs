﻿namespace LeetCodeEasy;

public class SymmetricTreeTask
{
    public bool IsSymmetric(TreeNode root) 
    {
        if (root == null)
        {
            return true;
        }    
        
        return IsMirror(root.left, root.right);
    }

    private bool IsMirror(TreeNode left, TreeNode right)
    {
        if (left == null && right == null)
        {
            return true;
        }   
        
        if (left == null || right == null)
        {
            return false;
        }    
        
        return (left.val == right.val) 
               && IsMirror(left.left, right.right) 
               && IsMirror(left.right, right.left);
    }
}
//https://leetcode.com/problems/symmetric-tree/

/** Definition for a binary tree node.
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
**/