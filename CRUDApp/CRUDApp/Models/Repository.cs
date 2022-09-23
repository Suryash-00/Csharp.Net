using System;
using System.Collections.Generic;

namespace CRUDApp.Models
{
    public static class Repository
    {
        private static List<Employee> allEmployess = new List<Employee>();
        public static IEnumerable<Employee> AllEmployees
        {
            get { return allEmployess; }
        }
        public static void Create(Employee employee)
        {
            allEmployess.Add(employee);
        }
        public static void Delete(Employee employee)
        {
            allEmployess.Remove(employee);
        }
    }
}
