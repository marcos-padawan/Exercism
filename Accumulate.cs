using System;
using System.Collections.Generic;

public static class AccumulateExtensions
{
    public static IEnumerable<TResult> Accumulate<TSource, TResult>(this IEnumerable<TSource> collection, Func<TSource, TResult> func)
    {
        foreach (TSource item in collection)
        {
            yield return func(item);
        }
    }
    // TSource == T       &&       TResult == U
    public static IEnumerable<U> AccumulateNonLazy<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        var result = new List<U>();

        foreach (T item in collection)
        {
            result.Add(func(item));
        }
        return result;
    }
}