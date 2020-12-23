using System;

namespace RelocationElementsTask
{
    /// <summary>
    /// Class for operations with array.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Moves all of the elements with set value to the end, preserving the order of the other elements.
        /// </summary>
        /// <param name="source"> Source array. </param>
        /// <param name="value">Source value.</param>
        /// <exception cref="ArgumentNullException">Thrown when source array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when source array is empty.</exception>
        public static void MoveToTail(int[] source, int value)
        {
            if (source is null)
            {
                throw new ArgumentNullException($"Array cannot be null.");
            }

            if (source.Length == 0)
            {
                throw new ArgumentException($"Array cannot be empty.");
            }

            for (int i = 1; i < source.Length; i++)
            {
                for (int j = 0; j < source.Length - i; j++)
                {
                    if (source[j] == value)
                    {
                        Swap(ref source[j], ref source[j + 1]);
                    }
                }
            }
        }

        private static void Swap(ref int i, ref int j)
        {
            int tmp = i;
            i = j;
            j = tmp;
        }
    }
}
