
using System;
using System.Collections.Generic;
using System.Linq;

class MyClass
{

    //static void Main(string[] args)
    //{
    //    int kases = Int32.Parse(System.Console.ReadLine().Trim());
    //    for (int kase = 1; kase <= kases; kase++)
    //    {
    //        int cities = Int32.Parse(System.Console.ReadLine().Trim());
    //        int roads = Int32.Parse(System.Console.ReadLine().Trim());
    //        var roadsArr = new List<(int, int, int)>();

    //        for (int i = 0; i < roads; i++)
    //        {
    //            int city1 = Int32.Parse(System.Console.ReadLine().Trim());
    //            int city2 = Int32.Parse(System.Console.ReadLine().Trim());
    //            int cost = Int32.Parse(System.Console.ReadLine().Trim());
    //            roadsArr.Add((city1, city2, cost));
    //        }
    //        Console.WriteLine(solution(roadsArr));
 
    //    }

    //}
    public static int solution(List<(int, int, int)> roadsArr)
    {                       //c1,   c2    numberofRoads, total cost
        var dic = new Dictionary<(int, int), (int, int)>();
        // fill dictionary
        // get most 2 cities with roads (number of roads between them) ==> X
        // foreach 2 cities that have numer of roads less than X accumilate its total cost
        foreach (var road in roadsArr)
        {
            (int c1, int c2, int cost) = road;
            if (dic.Keys.Contains((c1, c2)))
            {
                (int freq, int totalCost) = dic[(c1, c2)];
                freq++; totalCost += cost;
                dic[(c1, c2)] = (freq, totalCost);
            }
            else dic.Add((c1, c2), (1, cost));
        }
        var dicList = dic.ToList();
        int maxNumberOfRoads = dicList.OrderByDescending(x => x.Value.Item1).First().Value.Item1;
        var totalCostNeeded = dicList.Where(x => x.Value.Item1 < maxNumberOfRoads).Select(x => x.Value.Item2).Sum();
        return totalCostNeeded;




    }



}