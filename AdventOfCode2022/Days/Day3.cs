using AdventOfCode2022.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Days
{
    public static class Day3
    {
        public static string _sampleInput = @"vJrwpWtwJgWrhcsFMMfFFhFp
jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL
PmmdzqPrVvPwwTWBwg
wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn
ttgJtRGJQctTZtZT
CrZsJsPPZsGzwwsLwLmpwMDw";

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
            var lines = FileInputUtils.SplitLinesIntoStringArray(input);

            var totalScore = 0;

            foreach(string line in lines)
            {
                var len = line.Trim().Length;
                var half = len / 2;

                var firstCompartmentContents = line.Substring(0, half);
                var secondCompartmentContents = line.Substring(half, half);

                var common = FindCommonItem(firstCompartmentContents, secondCompartmentContents);
                totalScore += GetItemScore(common);
            }

            return totalScore.ToString();
        }

        internal static string RunPart2(string input)
        {
            var lines = FileInputUtils.SplitLinesIntoStringArray(input);

            var totalScore = 0;

            var tracker = 0;
            while (tracker < lines.Length)
            {
                var firstItems = GetItemSet(lines[tracker]);
                var secondItems = GetItemSet(lines[tracker + 1]);
                foreach(var item in lines[tracker+2]) { 
                    if (firstItems.Contains(item) && secondItems.Contains(item))
                    {
                        Console.WriteLine(item.ToString());
                        totalScore += GetItemScore(item);
                        break;
                    }
                }
                tracker += 3;
            }

            return totalScore.ToString();
        }

        #region Private Methods
        private static char FindCommonItem(string first, string second)
        {
            foreach(char ch in first)
            {
                if (second.Contains(ch))
                {
                    return ch;
                }
            }
            throw new Exception();
        }

        private static int GetItemScore(char item)
        {
            if (item >= 'a' && item <= 'z')
            {
                return item - 'a' + 1;
            }
            else
            {
                return item - 'A' + 27;
            }
        }

        private static HashSet<char> GetItemSet(string items)
        {
            var set = new HashSet<char>();

            foreach(char item in items) { 
                if (!set.Contains(item))
                {
                    set.Add(item);
                }
            }

            return set;
        }
        #endregion
    }
}
