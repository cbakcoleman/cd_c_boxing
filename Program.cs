using System;
using System.Collections.Generic;

namespace cd_c_boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an mpty list of type object
            List<object> list1 = new List<object>();

            // add the following values to the list:
            list1.Add(7);
            list1.Add(28);
            list1.Add(-1);
            list1.Add(true);
            list1.Add("chari");

            // Loop through the list and print all values
            for (var idx = 0; idx < list1.Count; idx++)
            if (list1[idx] is int)
            {
                System.Console.WriteLine(list1[idx]);
            }
            else if (list1[idx] is string)
            {
                System.Console.WriteLine(list1[idx]);
            }
            else if (list1[idx] is bool)
            {
                System.Console.WriteLine(list1[idx]);
            }

            // Add all values that are int type together and output the sum
            int sum = 0;
            for (var idx = 0; idx < list1.Count; idx++)
            if (list1[idx] is int)
            {
                sum = sum + list1[idx];
            }
            System.Console.WriteLine(sum);
        }
    }
}
