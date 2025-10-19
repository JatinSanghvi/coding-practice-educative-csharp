using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace JatinSanghvi.CodingInterview;

internal static class Utilities
{
    public static void PrintSolution<TInput, TResult>(TInput input, TResult result)
    {
        Console.WriteLine(input.ToPrintString() + " => " + result.ToPrintString());
    }

    public static string ToPrintString<T>(this T value)
    {
        return value switch
        {
            null => "null",
            bool or int or long or float or double or decimal => $"{value}",
            char => $"'{value}'",
            string => $"\"{value}\"",
            IEnumerable enumerable => $"[{string.Join(", ", enumerable.Cast<object>().Select(ToPrintString))}]",
            ITuple tuple => $"({string.Join(", ", Enumerable.Range(0, tuple.Length).Select(i => tuple[i].ToPrintString()))})",
            _ => throw new NotSupportedException($"Type [{value.GetType()}] is not supported.")
        };
    }
}