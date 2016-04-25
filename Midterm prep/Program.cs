using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_prep
{
    class Program
    {

        delegate int myDel(int a, int b);

        
        static void Main(string[] args)
        {
            Func<string, int, char> m;
            Action<double, int> act;
            myDel d1 = (q, x) => (q * x) / 2;

            int z = d1(1, 2);

            Console.Out.WriteLine(z);

            act = (d, i) => { };

            act(0.1, 1);

            m = (s, t) => 'c';
        }
    }
}
