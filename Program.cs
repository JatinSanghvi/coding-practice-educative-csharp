using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview;

public static class Program
{
    public static void Main(string[] args)
    {
        int patternNum = args.Length != 2 ? -1 : int.Parse(args[0]);
        int problemNum = args.Length != 2 ? -1 : int.Parse(args[1]);

        string namespacePrefix = typeof(Program).Namespace! + ".";

        // I chose the format of the solution class to let it be submitted to Educative.io with minimal change.
        Type[] testClasses = Assembly.GetExecutingAssembly().GetTypes()
            // Static classes are represented as "abstract sealed" in IL.
            .Where(type => type.IsAbstract && type.IsSealed && type.IsClass && type.Name == "Tests")
            .Where(type => type.Namespace!.StartsWith(namespacePrefix) && type.Namespace!.Split(".").Length == 4)
            .ToArray();

        string[] codingPatterns = testClasses
            .Select(type => type.Namespace!.Split(".")[2])
            .Distinct()
            .ToArray();

        string selectedPattern = Program.UserSelect("Coding Pattern", codingPatterns, patternNum);

        string[] codingProblems = testClasses
            .Where(type => type.Namespace!.Split(".")[2] == selectedPattern)
            .Select(type => type.Namespace!.Split(".")[3])
            .ToArray();

        string selectedProblem = Program.UserSelect("Problem", codingProblems, problemNum);

        try
        {
            // Invoke test method.
            testClasses
                .Single(type =>
                    type.Namespace!.Split(".")[2] == selectedPattern &&
                    type.Namespace!.Split(".")[3] == selectedProblem)
                .GetMethod("Run", BindingFlags.Public | BindingFlags.Static)!
                .Invoke(null, null);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Test Succeeded!");
            Console.ResetColor();
        }
        catch (TargetInvocationException te) when (te.InnerException is Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Test Failed!");
            Console.ResetColor();

            Console.WriteLine($"Message: {e.Message}");

            // Beautify stack trace.
            string[] lines = e.StackTrace!
                .Split("\n")
                .Where(line => line.Contains(namespacePrefix))
                .Select(line => Regex.Replace(line, @"(?<= at )([\w_]+\.){4}", "")) // Trim method information.
                .Select(line => Regex.Replace(line, @"(?<= in ).+?[\\/](?=[\w_]+\.cs)", "")) // Trim file information.
                .ToArray();

            Console.WriteLine(string.Join("\n", lines));
        }
    }

    public static string UserSelect(string category, string[] items, int id = -1)
    {
        // Assumes options to be in format: A01_PascalCaseValue.
        Dictionary<int, string> options = items.Order().ToDictionary(item => int.Parse(item[1..3]));

        if (id == -1)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (KeyValuePair<int, string> option in options)
            {
                // Convert 'PascalCaseValue' to 'Pascal Case Value'.
                string title = Regex.Replace(option.Value[4..], "(?<=[a-z])(?=[A-Z])|(?<=[A-Z])(?=[A-Z][a-z])", " ");
                Console.WriteLine($"{option.Key}. {title}");
            }

            Console.ResetColor();

            string? input = null;
            while (!int.TryParse(input, out id) || !options.ContainsKey(id))
            {
                Console.Write($"Select {category}: ");
                input = Console.ReadLine();
            }
        }

        return options[id];
    }
}
