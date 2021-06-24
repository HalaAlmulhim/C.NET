using System;
using System.Collections.Generic;

namespace firstProject
{
    class Program
    {

        public static void sayHello(){
            Console.WriteLine("Hello.");
        }

        public static string sayHi(){
            return "hi";
        }
        static void Main(string[] args)
        {
            // int myInt = 10;
            // double myFloat = 3.141;
            // short myShort = 2;
            // //short = -32,786 to 32,767
            // bool myBool = true;
            // char myChar = 'g';

            // string language = "C#";
            // Console.WriteLine($"Hello {language}!");

            // && = both conditions must be true
            // || = either conditions must be true
            // != change true to false or false to true

            // int numRings = 11;
            // if(numRings >= 5){
            //     Console.WriteLine("You are welcome to join the party!");
            // }
            // else if (numRings >2){
            //     Console.WriteLine($"{numRings} is not enough reings!");
            // }
            // else {
            //     Console.WriteLine("Go win some more rings!");
            // }

            // Random rand = new Random();
            // for(int i =0; i< 10; i++){
            //     Console.WriteLine(rand.Next(10));
            // }

            // collections (ArraySegment, List and Dictionaries)
            // bool[] nums = new bool[5]; 
            // foreach (bool item in nums)
            // {
            //     Console.WriteLine(item);
            // }

            //Array
            // string[] stArr ={"jason", "hala", "corey"};
            // foreach (string name in stArr)
            // {
            //     Console.WriteLine(name);
            // }

            //List
            // List<int> nums = new List<int>();
            // nums.Add(10);
            // nums.Add(6);
            // nums.Add(15);
            // nums.Add(42);
            // // Console.WriteLine(nums[2]);
            // // Console.WriteLine(nums.Count);
            // foreach (int num in nums)
            // {
            //     Console.WriteLine(num);
            // }

            //Dictionary
            // Dictionary<string, string> profile = new Dictionary<string, string>();
            // profile.Add("Name", "jason");
            // profile.Add("Location", "spokane, WA, USA");
            // profile.Add("FavoriteLanguage", "C#");
            // Console.WriteLine("MY Profile:");
            // Console.WriteLine("Name:" + profile["Name"]);
            // Console.WriteLine("From:" + profile["Location"]);
            // Console.WriteLine("Favorite Language:" + profile["FavoriteLanguage"]);

            Program.sayHello();
            Console.WriteLine(sayHi());

            //implicit
            int integerValue = 65;
            double doubleValue = integerValue;
            Console.WriteLine(doubleValue + 0.50);

            //explicit
            double dVal = 3.14159265358;
            int iVal =(int) dVal;
            Console.WriteLine(iVal);

        }
    }
}
