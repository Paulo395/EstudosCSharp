using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    internal class GenericTipe<T>
    {
        public T Value { get; set; }

        public GenericTipe(T value)
        {
            Value = value;
        }
    }
}
