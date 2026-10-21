using System;
using System.Collections.Generic;
using System.Text;

namespace adv2
{
    internal class methods
    {
        //Write Swap<T> method.
        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }


        //Write a generic method FindMax<T> that finds maximum value
        public static T Max<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

    }
}
