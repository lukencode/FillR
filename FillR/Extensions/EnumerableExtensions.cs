using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FillR.Extensions
{
    internal static class EnumerableExtensions
    {
        internal static T PickRandom<T>(this IEnumerable<T> source, Random random = null)
        {
            if (random == null)
                random = new Random();

            var index = random.Next(source.Count() - 1);

            return source.ElementAt(index);
        }

        internal static IEnumerable<T> Shuffle<T>(this IEnumerable<T> sequence, Random random = null)
        {
            if (random == null)
                random = new Random();

            int Length = sequence.Count();
            T[] retArray = sequence.ToArray();

            for (int i = 0; i < Length; i += 1)
            {
                int swapIndex = random.Next(i, Length);
                if (swapIndex != i)
                {
                    T temp = retArray[i];
                    retArray[i] = retArray[swapIndex];
                    retArray[swapIndex] = temp;
                }
            }

            return retArray;
        }
    }
}
