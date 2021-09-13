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

/* EXPLANATION

    There is a large pile of socks that must be paired by color. 
    Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.
    There is one pair of color  and one of color . There are three odd socks left, one of each color. The number of pairs is .

    Function Description
    sockMerchant has the following parameter(s):
    int n: the number of socks in the pile
    int ar[n]: the colors of each sock
    Returns
    int: the number of pairs
*/

class Result
{
    public static int sockMerchant(int n, List<int> ar)
    {
        ar.Sort();
        int amountDuplicates = 0;
        for (int i = 0; i < n; i++)
        {
            if (i + 1 < n)
            {
                int y = i + 1;
                if (ar[i] == ar[y])
                {
                    amountDuplicates++;
                    i++;
                }
            }
        }
        return amountDuplicates;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        // static input
        int amount = 10;
        List<int> colors = new List<int>();
        colors.AddRange(new List<int> { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 });

        Result.sockMerchant(amount, colors);

        // HackerRank Challenge code

        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int n = Convert.ToInt32(Console.ReadLine().Trim());

        //List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        //int result = Result.sockMerchant(n, ar);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
