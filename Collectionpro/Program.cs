
            using System;
            using System.Collections;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace Collections
    {
        internal class Class4
        {
            static void Main(string[] args)
            {
                HashSet<string> course1 = new HashSet<string>();
                course1.Add("C");
                course1.Add("C#");
                course1.Add("perl");
                course1.Add("php");

                HashSet<string> course2 = new HashSet<string>();
                course2.Add("C");
                course2.Add("C#");
                course2.Add("java");
                course2.Add("pythan");

                course1.UnionWith(course2);
                foreach (string c in course1)
                {
                    Console.WriteLine(c);
                }

                course1.IntersectWith(course2);
                foreach (string c in course1)
                {
                    Console.WriteLine(c);
                }

            }
        }
    }

