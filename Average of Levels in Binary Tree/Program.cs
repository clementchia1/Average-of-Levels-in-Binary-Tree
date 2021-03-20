namespace Average_of_Levels_in_Binary_Tree
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class TreeNode
    {
        public int val;

        public TreeNode left;

        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        internal class Program
        {
            internal static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
            }

            

            public IList<double> AverageOfLevels(TreeNode root)
            {
                IList<double> result = new List<double>();
                if (root == null)
                {
                    return result;
                }

                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(root);

                double level_sum = 0;

                while (queue.Count > 0)
                {
                    level_sum = 0;
                    int size = queue.Count;
                    for (int i = 0; i < size; i++)
                    {
                        TreeNode currentNode = queue.Dequeue();
                        level_sum += currentNode.val;
                        if (currentNode.left!=null)
                        {
                            queue.Enqueue(currentNode.left);
                        }
                        if (currentNode.right != null)
                        {
                            queue.Enqueue(currentNode.right);
                        }
                    }

                    Console.WriteLine("level_sum:" + level_sum + " size:" + size);
                    double level_avg = level_sum / size;
                    result.Add(level_avg);
                }

                return result;
            }
        }
    }
}

