using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal class MainService<T>
    {
        HashSet<T> list = new HashSet<T> ();
        public void AddInfo(T t)
        {
            list.Add (t);
        }

        public void ReturnCollection()
        {
            foreach (T t in list)
            {
                Console.WriteLine(t);
            }
        }
    }
}
