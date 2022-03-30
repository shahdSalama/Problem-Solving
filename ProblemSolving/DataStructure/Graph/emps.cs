using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Graph
{
    class emps
    {
        public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime)
        {
            //       index of emp, level
            var q = new Queue<(int, int)>();
            q.Enqueue((headID, 0));
            int time = int.MinValue;
            var managerEmployeesDictionary = GetManagerEmployeesDictionary(headID, manager);
            while (q.Count != 0)
            {
                (int currManagerI, int timeneeded) = q.Dequeue();
                if (!managerEmployeesDictionary.TryGetValue(currManagerI, out var _))
                {
                    time = Math.Max(time, timeneeded);
                    continue;
                }
                foreach (var employee in managerEmployeesDictionary[currManagerI])
                {
                    // n is the indexes of the employees under the current manager
                    q.Enqueue((employee, timeneeded + informTime[currManagerI]));
                }
            }
            return time;
        }
        private Dictionary<int, List<int>> GetManagerEmployeesDictionary(int headID, int[] manager)
        {
            var ManagerEmployeeDictionary = new Dictionary<int, List<int>>();
            //                             manager index     ,  employee indexies

            for (int i = 0; i < manager.Length; i++)
            {
                // i is the index of the maneger/emp, // manager[i] is the index of its manager
                if (ManagerEmployeeDictionary.TryGetValue(manager[i], out var val))
                    ManagerEmployeeDictionary[manager[i]].Add(i);
                else
                    ManagerEmployeeDictionary.Add(manager[i], new List<int> { i });
            }
            return ManagerEmployeeDictionary;

        }

       

    }
}
