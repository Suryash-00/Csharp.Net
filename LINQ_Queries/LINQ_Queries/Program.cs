using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Source  
            List<int> integerList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /*
            var QuerySyntax = from obj in integerList
                              where obj > 5
                              select obj;
            */
            //var QuerySyntax = integerList.Where(obj => obj > 5).ToList();
            var QuerySyntax= (from obj in integerList
                              where obj>5
                              select obj).Sum();
            Console.WriteLine(QuerySyntax);
            /*foreach (var item in QuerySyntax)
            {
                Console.WriteLine(item + " ");
            }*/
        }
    }
}