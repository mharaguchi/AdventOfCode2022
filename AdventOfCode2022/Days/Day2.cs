using AdventOfCode2022.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Days
{
    public static class Day2
    {
        const int WIN_SCORE = 6;
        const int DRAW_SCORE = 3;
        const int LOSE_SCORE = 0;

        private static Dictionary<string, int> _shapeScores = new Dictionary<string, int>() { { "X", 1 }, { "Y", 2 }, { "Z", 3 } };

        public static string _sampleInput = @"A Y
B X
C Z";

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
                var tokens = StringUtils.SplitInOrder(line, new string[]{ " " });
                var shapeScore = _shapeScores[tokens[1]];
                var resultScore = GetResultScore(tokens[0], tokens[1]);
                totalScore = totalScore + shapeScore + resultScore;
            }

            return totalScore.ToString();
        }

        internal static string RunPart2(string input)
        {
            var lines = FileInputUtils.SplitLinesIntoStringArray(input);

            var totalScore = 0;

            foreach (string line in lines)
            {
                var tokens = StringUtils.SplitInOrder(line, new string[] { " " });
                var myShape = GetMyShape(tokens[0], tokens[1]);
                var shapeScore = _shapeScores[myShape];
                var resultScore = GetResultScore(tokens[0], myShape);
                totalScore = totalScore + shapeScore + resultScore;
            }

            return totalScore.ToString();
        }

        #region Private Methods
        private static int GetResultScore(string oppShape, string myShape)
        {
            switch (oppShape)
            {
                case "A":
                    if (myShape == "X")
                    {
                        return DRAW_SCORE;
                    }
                    else if (myShape == "Y")
                    {
                        return WIN_SCORE;
                    }
                    else if (myShape == "Z")
                    {
                        return LOSE_SCORE;
                    }
                    else
                    {
                        return -1;
                    }
                case "B":
                    if (myShape == "X")
                    {
                        return LOSE_SCORE;
                    }
                    else if (myShape == "Y")
                    {
                        return DRAW_SCORE;
                    }
                    else if (myShape == "Z")
                    {
                        return WIN_SCORE;
                    }
                    else
                    {
                        return -1;
                    }
                case "C":
                    if (myShape == "X")
                    {
                        return WIN_SCORE;
                    }
                    else if (myShape == "Y")
                    {
                        return LOSE_SCORE;
                    }
                    else if (myShape == "Z")
                    {
                        return DRAW_SCORE;
                    }
                    else
                    {
                        return -1;
                    }
                default: return -1;
            }
        }

        private static string GetMyShape(string oppShape, string outcome)
        {
            switch (oppShape)
            {
                case "A":
                    if (outcome == "X")
                    {
                        return "Z";
                    }
                    else if (outcome == "Y")
                    {
                        return "X";
                    }
                    else if (outcome == "Z")
                    {
                        return "Y";
                    }
                    else
                    {
                        return "";
                    }
                case "B":
                    if (outcome == "X")
                    {
                        return "X";
                    }
                    else if (outcome == "Y")
                    {
                        return "Y";
                    }
                    else if (outcome == "Z")
                    {
                        return "Z";
                    }
                    else
                    {
                        return "";
                    }
                case "C":
                    if (outcome == "X")
                    {
                        return "Y";
                    }
                    else if (outcome == "Y")
                    {
                        return "Z";
                    }
                    else if (outcome == "Z")
                    {
                        return "X";
                    }
                    else
                    {
                        return "";
                    }
                default: return "";
            }
        }
        #endregion
    }
}
