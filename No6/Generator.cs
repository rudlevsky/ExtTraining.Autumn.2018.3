using System;
using System.Collections.Generic;

namespace No6
{
    public static class Generator<T>
    {
        public static IEnumerable<T> Generate(T first, T second, int n, Func<T, T, T> func)
        {
            yield return first;
            yield return second;

            for (int i = 2; i < n; i++)
            {
                T temp = func(second, first);

                yield return temp;

                first = second;
                second = temp;
            }
        }
    }
}
