using AdventOfCode2022.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Days
{
    public static class Day1
    {
        public static string _sampleInput = @"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000";

        public static List<int> elves = new List<int>();

        public static string Run(string input)
        {
            //return RunPart1(input);
            return RunPart2(input);
        }

        internal static string RunPart1(string input)
        {
            var sets = FileInputUtils.SplitInputByBlankLines(input);
            for (int i = 0; i < sets.Length; i++)
            {
                var nums = FileInputUtils.SplitLinesIntoIntList(sets[i]);
                var sum = nums.Sum();
                elves.Add(sum);
            }

            return elves.Max().ToString();
        }

        internal static string RunPart2(string input)
        {
            var sets = FileInputUtils.SplitInputByBlankLines(input);
            for (int i = 0; i < sets.Length; i++)
            {
                var nums = FileInputUtils.SplitLinesIntoIntList(sets[i]);
                var sum = nums.Sum();
                elves.Add(sum);
            }

            var total = 0;
            for (int i = 0; i < 3; i++)
            {
                var max = elves.Max();
                total += elves.Max();
                elves.Remove(max);
            }
            return total.ToString();
        }
    }
}
