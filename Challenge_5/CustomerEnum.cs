using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    public class CustomerEnum
    {
        enum Type {Potential, Current, Past};

        static void main()
        {
            int x = (int)Type.Current;
            int y = (int)Type.Past;
            int z = (int)Type.Potential;
            Console.WriteLine("Current = {0}", x);
            Console.WriteLine("Past = {0}", y);
            Console.WriteLine("Potential = {0}", z);
             
        }
    }
}
