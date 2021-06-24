using System;

namespace fundamentalss
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            //Create a Loop that prints all values from 1-255
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }

            // Optional
            // int i = 1;
            // while(i <= 255)
            // {
            //     Console.WriteLine(i);
            //     i++;
            // }

             //Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
            for (int j = 1; j <= 100; j++) {
                if ( j % 3 == 0 || j % 5 == 0){
                    if ( j % 3 == 0){
                        if(j % 5 != 0)
                        Console.WriteLine(j + " divisible by 3");
                    }
                    else
                    Console.WriteLine(j + " divisible by 5");
                }

            // Optional
            // int j = 1;
            // while( j <= 100)
            // {
            //     if ( j % 3 == 0 || j % 5 == 0)
            //     {
            //         if ( j % 3 == 0)
            //         {
            //             if(j % 5 != 0)
            //             Console.WriteLine(j + " divisible by 3");
            //         }
            //         else
            //         Console.WriteLine(j + " divisible by 5");
            //     }
            //     j++;
            // }

            //Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5,
            // and "FizzBuzz" for numbers that are multiples of both 3 and 5
            for (int q = 1; q <= 100; q++)
            {
                if ( q % 3 == 0 || q % 5 == 0)
                {
                    if ( q % 3 == 0)
                    {
                        if(q % 5 == 0)
                        Console.WriteLine("FizzBuzz");
                        else
                        Console.WriteLine("Fizz");
                    }
                    else
                    Console.WriteLine("Buzz");
                }
            }

            //Optional
            // int q = 1;
            // while(q <= 100)
            // {
            //     if ( q % 3 == 0 || q % 5 == 0)
            //     {
            //         if ( q % 3 == 0)
            //         {
            //             if(q % 5 == 0)
            //             Console.WriteLine("FizzBuzz");
            //             else
            //             Console.WriteLine("Fizz");
            //         }
            //         else
            //         Console.WriteLine("Buzz");
            //     }
            //     q++;
            // }
            }
        }
    }
}
