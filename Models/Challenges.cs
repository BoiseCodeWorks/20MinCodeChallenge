using System.Collections.Generic;
using System.Linq;

namespace challenges.Models
{
    public static class Challenges
    {
        public static float MortgageRate { get; set; } = .05f;

        public static int Double(int x)
        {
            return x + x;
        }
        public static float Double(float x)
        {
            return x + x;
        }
        public static double Double(double x)
        {
            return x + x;
        }

        public static bool IsNumberEven(int x)
        {
            return x % 2 == 0;
        }
        public static bool IsNumberEven(float x)
        {
            return x % 2 == 0;
        }
        public static bool IsNumberEven(double x)
        {
            return x % 2 == 0;
        }

        public static string GetFileExtension(string x)
        {
            string[] fileName = x.Split('.');
            if (fileName.Length > 1)
            {
                return fileName[^1];
            }
            return null;
        }

        public static string LongestString(string[] x)
        {
            string longest = "";
            for (int i = 0; i < x.Length; i++)
            {
                string current = x[i];
                if (current.Length > longest.Length)
                {
                    longest = current;
                }
            }
            return longest;
        }


        public static int ArraySum(int[] x)
        {
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }
            return sum;
        }
        public static float ArraySum(float[] x)
        {
            float sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }
            return sum;
        }
        public static double ArraySum(double[] x)
        {
            double sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }
            return sum;
        }

        public static List<List<int>> ListGroup(int[] arr)
        {
            // create a dictionary
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            // loop over array and add each value as a key
            foreach (int val in arr)
            {
                //  if it doesn't exist 
                if (!dict.ContainsKey(val))
                {
                    // add a new list
                    dict.Add(val, new List<int>());
                }
                // push into an array at that key
                dict[val].Add(val);
            }

            //Return Dictionary Values as an array
            return dict.Values.ToList();

        }


        public static int[][] ArrayGroup(int[] arr)
        {
            // create a dictionary
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            // loop over array and add each value as a key
            foreach (int val in arr)
            {
                //  if it doesn't exist 
                if (!dict.ContainsKey(val))
                {
                    // add a new list
                    dict.Add(val, new List<int>());
                }
                // push into an array at that key
                dict[val].Add(val);
            }

            //Return Dictionary Values as an array
            var values = dict.Values.ToList();
            var intList = new List<int[]>();
            values.ForEach(v => intList.Add(v.ToArray()));
            return intList.ToArray();
        }


    }
}