using AdventOfCode2022.Days;
using AdventOfCode2022.Utils;

namespace AdventOfCode2022
{
    public static class DayRunner
    {
        public static string GetAnswer(int day, int part, bool useSampleData)
        {
            var input = FileInputUtils.GetInput(day);
            return RunDay(input, day, part, useSampleData).ToString();
        }

        private static string RunDay(string input, int day, int part, bool useSampleData)
        {
            return day switch
            {
                1 => Day1.Run(input, part, useSampleData),
                2 => Day2.Run(input, part, useSampleData),
                _ => "Error selecting day",
            }; ;
        }
    }
}
