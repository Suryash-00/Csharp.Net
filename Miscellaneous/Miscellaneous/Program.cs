using System;
using System.Collections.Generic;


namespace Random
{
    class Rand
    {
        static void Main(string[] args)
        {
            /*
               var names = new List<string> { "Suryash", "Deepak", "Anurag" };
               names.Add("Arjun");
               names.Add("Vivek");
               names.Add("Yash");
               names.Remove("Vivek");
               foreach (string name in names)
               {
                   Console.WriteLine($"Hello {name.ToUpper()}");
               }
               Console.WriteLine(names[1]);
               int index = names.IndexOf("Yash");
               Console.WriteLine(index);
               names.Sort();
               for (int i=0; i<names.Count; i++)
               {
                   Console.WriteLine(names[i]);
               }
           }
       }
   }
   */

            //Fibonacci Numbers
            
            var fibo = new List<int> { 1, 1 };

            while (fibo.Count < 10)
            {
                var previous = fibo[fibo.Count - 1];
                var previous2 = fibo[fibo.Count - 2];
                fibo.Add(previous + previous2);
            }
            foreach (var item in fibo)
            {
                Console.WriteLine(item);
            }
        }
    }
}