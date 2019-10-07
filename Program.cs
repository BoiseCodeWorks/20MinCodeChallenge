using System;
using challenges.Models;

namespace challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Challenges.Double(7) + "= 14?");
            System.Console.WriteLine(Challenges.Double(7.5) + "= 15?");
            System.Console.WriteLine(Challenges.Double(7.5f) + "= 15?");

            System.Console.WriteLine(Challenges.IsNumberEven(7) + "= False?");
            System.Console.WriteLine(Challenges.IsNumberEven(6) + "= True?");


            System.Console.WriteLine(Challenges.GetFileExtension("hello.txt") + " = txt?");
            System.Console.WriteLine(Challenges.GetFileExtension("hello") + "=  ?");

            System.Console.WriteLine(Challenges.LongestString(new string[] { "a", "b", "cd" }) + "= cd?");

            System.Console.WriteLine(Challenges.ArraySum(new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }) + " = 100");


        }
    }
}
