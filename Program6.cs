using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate string MyDel(string str);
    class Program6
    {
            event MyDel MyEvent;

             Program6()
            {
                this.MyEvent += new MyDel(this.WelcomeUser);
            }
            public string WelcomeUser(string username)
            {
                return "Welcome " + username;
            }
            static void Main(string[] args)
            {
                Program6 obj1 = new Program6();
                string result = obj1.MyEvent("Shahil");
                Console.WriteLine(result);
            Console.ReadLine();
            }
        }
    }
    

