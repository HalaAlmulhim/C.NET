using System;
using System.Collections.Generic;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            //Create an empty List of type object
            List<object> lis = new List<object>();

            //Add the following values to the list: 7, 28, -1, true, "chair"
            lis.Add(7);
            lis.Add(28);
            lis.Add(-1);
            lis.Add(true);
            lis.Add("chair");

            //Loop through the list and print all values (Hint: Type Inference might help here!)
            int intVals = 0;
            foreach( var item in lis)
            {
                Console.WriteLine(item);
                
                //Add all values that are Int type together and output the sum
                if(item is int)
                {
                    intVals += (int)item;
                }
            }
            Console.WriteLine("Integers Sum: " + intVals);
        }
    }
}
