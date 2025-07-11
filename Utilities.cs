using System;
using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;

namespace JatinSanghvi.CodingInterview;

internal static class Utilities
{
    public static void PrintSolution<TInput, TResult>(TInput input, TResult result)
    {
        Console.WriteLine(input.Print() + " => " + result.Print());
    }

    public static string Print<T>(this T value)
    {
        return value switch
        {
            null => "null",
            bool or int or long or float or double or decimal => $"{value}",
            char => $"'{value}'",
            string => $"\"{value}\"",
            IEnumerable enumerable => $"[{string.Join(", ", enumerable.Cast<object>().Select(Print))}]",
            ITuple tuple => $"({string.Join(", ", Enumerable.Range(0, tuple.Length).Select(i => tuple[i].Print()))})",
            _ => throw new NotSupportedException($"Type [{value.GetType()}] is not supported.")
        };
    }
}