using System;

namespace lance
{
    class Program
    {
        public static void Main()
        {
            int n;
            float high, low;
            int[] a = new int[50];
            Console.Write("How many integers?");
            string h = Console.ReadLine();
            n = Int32.Parse(h);
            Console.WriteLine("Enter the integers:");
            for (int i = 0; i < n; i++)
            {
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
            Console.Write("");
            high = a[0];
            low = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] > high)
                    high = a[i];
                else if (a[i] < low)
                    low = a[i];
            }
            Console.WriteLine("Highest Integer is {0}", high);
            Console.WriteLine("Smallest Integer is {0}", low);
        }
    }

}
