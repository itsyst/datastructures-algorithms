// See https://aka.ms/new-console-template for more informationusing System;
namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Three Number Sum
            int[] array = new int[] { 12, 3, 1, 2, -6, 5, -8, 6 };
            int target = 0;
            var result = ThreeNumberSum.ThreeNumbersSum3(array, target);
            foreach (var item in result)
            {
                // item.ToList().ForEach(Console.Write);
                // Array.ForEach(item, Console.Write);
                Console.WriteLine("[" + "{0}", string.Join(", ", item)+ "]");
            }
        }
    }
}


