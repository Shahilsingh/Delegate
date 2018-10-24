using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate int  Add(int a, int b);
    class Program4
    {
        public static int Addval(int val1 ,int val2 )
        {
            return  val1 + val2;
        }
        static void Main()
        {
            Add delObj = new Add(Addval);
            Console.Write("Please Enter Values \n");
            int v1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ADD");
            int v2 = Int32.Parse(Console.ReadLine());
            double res = delObj(v1, v2);
            Console.WriteLine("Result :Add of this two Number" + res);
            Console.ReadLine();

        }
    }
}
