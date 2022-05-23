using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution
{
    public class Solution
    {

        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {
            // group empoloyees by company name
            // foreach .. each company calculate the average age
            // add it to the result dictionary
            var dic = new Dictionary<string, int>();
            var groups = employees.GroupBy(u => u.Company).Select(grp => grp.ToList()).ToList();
            foreach (var group in groups)
            {
                if (group.Count == 0) continue;
                dic.Add(group[0].Company, 0);
                var totalAgeInCompany = 0;
                var totalEmployees = 0;
                foreach (var emp in group)
                {
                    totalAgeInCompany += emp.Age;
                    totalEmployees++;
                }
                dic[group[0].Company] = (int)Math.Floor((double)totalAgeInCompany / totalEmployees);
            }
            return dic.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }

        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
        {
            var dic = new Dictionary<string, int>();
            var groups = employees.GroupBy(u => u.Company).Select(grp => grp.ToList()).ToList();
            foreach (var group in groups)
            {

                if (group.Count == 0) continue;
                dic.Add(group[0].Company, 0);
                foreach (var emp in group)
                {
                    dic[group[0].Company]++;
                }
            }
            return dic;
        }

        public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
        {
            var dic = new Dictionary<string, Employee>();
            var groups = employees.GroupBy(u => u.Company).Select(grp => grp.ToList()).ToList();
            foreach (var group in groups)
            {

                if (group.Count == 0) continue;
                var oldesEmp = new Employee();
                oldesEmp.Age = 0;
                foreach (var emp in group)
                {
                    if (emp.Age > oldesEmp.Age)
                        oldesEmp = emp;
                }
                dic.Add(group[0].Company, oldesEmp);
            }
            return dic;
        }

 
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }
    }
}