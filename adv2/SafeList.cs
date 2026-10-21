using System;
using System.Collections.Generic;
using System.Text;

namespace adv2
{
    public class SafeList<T> : List<T>
    {
        public new T this[int index]
        {
            get => (index >= 0 && index < Count) ? base[index] : default!;
            set => base[index] = value;
        }
    }
}
