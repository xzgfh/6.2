using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector<double> v1 = new Vector<double>(1.0, 0.0, 0.0);
            Console.WriteLine(v1.ToString());
            Vector<double> v2 = new Vector<double>(0.0, 1.0, 0.0);
            Console.WriteLine(v2.ToString());
            Console.WriteLine("length {0}", v1.length());
            Console.WriteLine("length {0}", v2.length());
            Console.WriteLine("angle {0}", v1.angle(v1, v2));
            Console.ReadKey();
        }
    }
}
