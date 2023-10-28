using AdventOfCode2022.Days;
using AdventOfCode2022.Utils;

namespace AdventOfCode2022
{
    public static class DayRunner
    {
        const int DAY = 1;

        public static string GetAnswer()
        {
            var input = FileInputUtils.GetInput(DAY);
            return Day1.Run(input).ToString();
        }
    }
}
