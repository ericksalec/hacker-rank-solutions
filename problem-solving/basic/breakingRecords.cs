using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> breakingRecords(List<int> scores)
    {
        int countH = 0;
        int countL = 0;

        int count = scores.Count();
        List<int> result = new List<int>();

        int hScore = scores[0];
        int lScore = scores[0];

        for (int i = 0; i < count; i++)
        {
            if (hScore < scores[i])
            {
                hScore = scores[i];
                countH++;
            }
            if (lScore > scores[i])
            {
                lScore = scores[i];
                countL++;
            }
        }
        Console.Write(countH);
        Console.Write(countL);

        result.Add(countH);
        result.Add(countL);

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
