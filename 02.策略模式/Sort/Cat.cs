using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.ComTypes;

namespace _02.策略模式.Sort
{
    public class Cat
    {
        public int Height { get; set; }

        public int Weight { get; set; }

        public Cat(int weight = 0, int height = 0)
        {
            Height = height;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"[Height={Height},Weight={Weight}]";
        }
    }

    public class CatHeightComparer : IComparer<Cat>
    {
        public int Compare([NotNull] Cat x, [NotNull] Cat y)
        {
            if (x.Height > y.Height)
            {
                return 1;
            }
            else if (x.Height < y.Height)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    public class CatWeightComparer : IComparer<Cat>
    {
        public int Compare([NotNull] Cat x, [NotNull] Cat y)
        {
            if (x.Weight > y.Weight)
            {
                return 1;
            }
            else if (x.Weight < y.Weight)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
