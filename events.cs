using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void mydel();
    class events
    {
        static event mydel myevent;
        static event mydel myevent2;
        public void Mybook()
        {
            Console.WriteLine("I have a pen");
        }
        public void MyLap()
        {
            Console.WriteLine("My laptop condition is good ");
            
        }
        public void MyPhone()
        {
            Console.WriteLine("My phone is good");
            
        }
        public static void Main()

        {
            events obj = new events();
            myevent += new mydel(obj.MyPhone);
            myevent2 += new mydel(obj.MyLap);

            myevent2();
            myevent();
            myevent2 -= new mydel(obj.MyLap);
            try
            {
                myevent2();
            }
            catch(Exception e)
            {
                Console.WriteLine("this event is deleted");
            }
            myevent();

            Console.ReadLine();


            //Functiondelegate("hello shahil");
            //Functiondelegate = new Functiondelegate(obj.MyLap);
            //Functiondelegate("hello ravi");
            //Functiondelegate = new Functiondelegate(obj.MyPhone);
            //Functiondelegate("hello Mohan");
        }
    }
}
