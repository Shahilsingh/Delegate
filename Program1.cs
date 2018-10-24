using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void lengthdelegate();

    class Program1
    {
        public static void Ravi()
        {
            Console.WriteLine("Ravi is a good boy");
            Console.ReadLine();
        }
        public static void Main()
        {
           lengthdelegate lengthdelegate = new lengthdelegate(Ravi);

            lengthdelegate();
        }
    }
}
