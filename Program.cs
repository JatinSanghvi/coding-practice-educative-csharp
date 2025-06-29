using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace JatinSanghvi.CodingInterview;

public static class Program
{
    public static void Main(string[] args)
    {
        int patternNum = args.Length == 2 ? int.Parse(args[0]) : -1;
        int problemNum = args.Length == 2 ? int.Parse(args[1]) : -1;

        string namespacePrefix = typeof(Program).Namespace + ".";

        // The structure for solution classes is chosen specifically to make it easier to be submitted to Educative.io.
        Type[] classes = Assembly.GetExecutingAssembly().GetTypes()
            // Static classes are designated as 'abstract sealed' in the IL.
            .Where(type => type.IsAbstract && type.IsSealed && type.IsClass && type.Name == "Tests")
            .Where(type => type.Namespace.StartsWith(namespacePrefix) && type.Namespace.Split(".").Length == 4)
            .ToArray();

        string[] codingPatterns = classes
            .Select(type => type.Namespace.Split(".")[2])
            .Distinct()
            .ToArray();

        string selectedPattern = UserSelect("Coding Pattern", codingPatterns, patternNum);

        string[] codingProblems = classes
            .Where(type => type.Namespace.Split(".")[2] == selectedPattern)
            .Select(type => type.Namespace.Split(".")[3])
            .ToArray();

        string selectedProblem = UserSelect("Coding Problem", codingProblems, problemNum);

        try
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            classes
                .Where(type => type.Namespace.Split(".")[2] == selectedPattern)
                .Where(type => type.Namespace.Split(".")[3] == selectedProblem)
                .Single()
                .GetMethod("Run", BindingFlags.Public | BindingFlags.Static)
                .Invoke(obj: null, parameters: null);

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
        // Assume options to be in format: A01_PascalCaseValue.
        Dictionary<int, string> options = items.Order().ToDictionary(item => int.Parse(item[1..3]));

        if (id == -1)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (KeyValuePair<int, string> option in options)
            {
                // Convert 'PascalCaseValue' to 'Pascal Case Value'.
                string title = Regex.Replace(option.Value[4..], "(?<=[a-z])(?=[A-Z])|(?<=[A-Z])(?=[A-Z][a-z])", " ");
                Console.WriteLine($"{option.Key,2}. {title}");
            }

            Console.ResetColor();

            do
            {
                Console.Write($"Select {category}: ");
            }
            while (!int.TryParse(Console.ReadLine(), out id) || !options.ContainsKey(id));
        }

        return options[id];
    }
}
