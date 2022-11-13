using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Tree
{
    class camera
    {
        public static int MinCameraCover(TreeNode root)
        {
            var dic = new Dictionary<int, int>();

            var q = new Queue<(int, TreeNode)>();
            q.Enqueue((0, root));
          
            while (q.Count != 0)
            {
                (int level, var node) = q.Dequeue();
                if (dic.Keys.Contains(level)) dic[level]++;
                else dic.Add(level, 1);

                if (node.left != null) q.Enqueue((level + 1, node.left));
                if (node.right != null) q.Enqueue((level + 1, node.right));
            }
            int lastparent = dic.ToList().Last().Key -1;
            if (lastparent % 2 == 0)
            {
                return dic.ToList().Where(x => x.Key % 2 == 0).Select(x => x.Value).ToList().Sum();
            }
            return dic.ToList().Where(x => x.Key % 1 == 0).Select(x => x.Value).ToList().Sum();
        }
       

        
    }
}


