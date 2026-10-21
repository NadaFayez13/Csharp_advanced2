using System;
using System.Collections.Generic;
using System.Text;

namespace adv2
{
    internal interface IRepository<T>
    {
        
            void Add(T item);
            T Get(int id);
            List<T> GetAll();
        }
    
}
