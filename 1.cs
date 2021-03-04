using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
        class MyList<T>
        {
            static void Main()
            {
                List<T> list = new List<T>();

            }

            public void Method() { }
            int[] arr = new int[5];
            public int this[int list]
            {
                get { return arr[list]; }
                set { arr[list] = value; }
            }
        }
    }