using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // Three Basic Arrays
            //1- Create an array to hold integer values 0 through 9
            int[] integers =  {0,1,2,3,4,5,6,7,8,9};

            // 2- Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] names = {"Tim", "Martin", "Nikki","Sara"};

            //3- Create an array of length 10 that alternates between true and false values, starting with true
            bool[] bools = {true, false, true, false, true, false, true, false, true, false};

            //List of Flavors
            //1- Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> flavors = new List<string>();
            flavors.Add("Almond Chocolate Coconut");
            flavors.Add("Strawberry");
            flavors.Add("Banana");
            flavors.Add("Caramel Cheesecake");
            flavors.Add("Vanilla");

            //2- Output the length of this list after building it
            Console.WriteLine(flavors.Count);

            //3- Output the third flavor in the list, then remove this value
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);

            //4- Output the new length of the list (It should just be one fewer!)
            Console.WriteLine(flavors[2]);
            Console.WriteLine(flavors.Count);

            //User Info Dictionary
            // 1- Create a dictionary that will store both string keys as well as string values
            Dictionary<string,string> names_flavors = new Dictionary<string,string>();

            //2-Add key/value pairs to this dictionary where:
            //each key is a name from your names array
            //each value is a randomly select a flavor from your flavors list.
            Random rand = new Random();
            for(int i = 0; i < names.Length; i++)
            {
                int randNum = rand.Next(0, 4);
                names_flavors.Add(names[i], flavors[randNum]);
            }
            //Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach( var entry in names_flavors)
            {
                Console.WriteLine(entry.Key + " Likes: " + entry.Value);
            }
        }
    }
}
