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

    }
}