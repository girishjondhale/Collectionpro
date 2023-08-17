using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 20, 30, };
            int[] arr2 = new int[8];

            ArrayList list = new ArrayList();
            list.Add(11);
            list.Add(12);
            list.Add(13);

            list.Insert(0, 1);
            list.Insert(2, 200);

            list.AddRange(arr);

            list
        }
    }
}
