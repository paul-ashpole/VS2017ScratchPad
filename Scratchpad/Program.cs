using System;

namespace Scratchpad
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0b1, 0b1_0, 0b100, 0b10_00 }; //binary literals and numerical seperators

            var (sum, count) = Tally(numbers);  //need nuget for System.ValueTuple

            Console.WriteLine($"Sum: {sum}, count: {count}");
            Console.ReadLine();
        }

        private static (int sum, int count) Tally(int[] values)
        {
            var r = (s: 0, c: 0);
            foreach (var v in values)
            {
                Add(v, 1);
            }
            return r;

            void Add(int s, int c) { r.s += s; r.c += c; }  //local function
        }
    }
}
