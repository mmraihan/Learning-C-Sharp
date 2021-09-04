using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_Generic_2
{
    class DataStore <T>
    {
        private T[] _data = new T[3];

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
            {
                _data[index] = item;
            }
        }

        public T GetData(int index)
        {
            if (index>=0 && index<10)
            {
                return _data[index];
            }
            return default(T);
        }
    }
}
