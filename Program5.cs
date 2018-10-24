using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void Functiondelegate(string k);
    class Program5
    {
           public void Mybook(string j)
        {
            Console.WriteLine("I have a pen");
        }
        public void MyLap(string a)
        {
            Console.WriteLine("My laptop condition is good ");
        }
        public void MyPhone(string m)
        {
            Console.WriteLine("My phone is good");
            Console.ReadLine();
        }
        public static void Main()
        {
            Program5 obj = new Program5();

            Functiondelegate  Functiondelegate = new Functiondelegate(obj.Mybook);
            Functiondelegate("hello shahil");
             Functiondelegate  = new Functiondelegate(obj.MyLap);
            Functiondelegate("hello ravi");
            Functiondelegate  = new Functiondelegate(obj.MyPhone);
            Functiondelegate("hello Mohan");
    }
    }
}
