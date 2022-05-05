using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.MeduimChallenges
{
    public class SnapshotArray
    {
        Dictionary<int, Dictionary<int, int>> map;
        int count = 0;
        public SnapshotArray(int length)
        {
            map = new Dictionary<int, Dictionary<int, int>>();
        }

        public void Set(int index, int val)
        {
            // key exists
            if (map.TryGetValue(index, out Dictionary<int, int> snapVals))
            {

                if (snapVals.TryGetValue(count, out int _))
                    snapVals[count] = val;
                else
                    snapVals.Add(count, val);

            }
            else
            {
                // key 1st time to be added
                var dic = new Dictionary<int, int>();
                dic.Add(count, val);
                map.Add(index, dic);
            }

        }

        public int Snap()
        {
            count++;
            return count - 1;
        }


        public int Get(int index, int snap_id)
        {
            if (map.TryGetValue(index, out var val) && val.TryGetValue(snap_id, out var val1))
                return map[index][snap_id];

            if (map.TryGetValue(index, out var val2) && val2.Count != 0)
            {
                var pevSnaps = val2.Keys.Where(x => x < snap_id);
                if (pevSnaps.Count() != 0) return val2[pevSnaps.Last()];


            }

            return 0;

        }
    //["SnapshotArray","snap","get","get","set","get","set","get","set"]
    //    [[2]        [],      [1,0],[0,0],[1,8],[1,0],[0,20],[0,0],[0,7]]
   
}




}
