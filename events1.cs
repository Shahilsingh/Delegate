using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void Mydel();
    class events1
    {
        static event mydel myevent;
        static event mydel myevent2;
        static event mydel myevent3;
        

        public void Ritu()
        {
            Console.WriteLine("ritu is sleeping");
        }
        public void Ritucalling()
        {
            Console.WriteLine("Hello Shahil");
        }
        public void Invalidcall()
        {
            Console.WriteLine("who are u");
        }
        public static void Main()
        {
            events1 obj = new events1();
            myevent += new mydel (obj.Ritu);
            myevent2 += new mydel (obj.Ritucalling);
            myevent3 += new mydel (obj.Invalidcall);
            myevent();
            myevent2();
            myevent3();
            myevent -= new mydel(obj.Ritu);
            myevent2 -= new mydel(obj.Ritucalling);
            try
            {
                myevent();
                
            }
            catch(Exception e)
            {
                Console.WriteLine("delete the text");
            }
            
            myevent3();
            Console.ReadLine();

        }
    }
}
