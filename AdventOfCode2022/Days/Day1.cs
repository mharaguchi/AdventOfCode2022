using AdventOfCode2022.Utils;

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

        public static string Run(string input, int part, bool useSampleData)
        {
            if (part == 1)
            {
                if (useSampleData)
                {
                    return RunPart1(_sampleInput);
                }
                return RunPart1(input);
            }
            else
            {
                if (useSampleData)
                {
                    return RunPart2(_sampleInput);
                }
                return RunPart2(input);
            }
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
