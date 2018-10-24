using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
namespace CRUD
{
    [Serializable]
    class Tutorial
    {
        
        static void Main(string[] args)
        {
            
            String lStrFilePath = @"G:\HomeNew.txt";
            Sfile sFileObj = new Sfile();
            if (sFileObj.isFileExit(lStrFilePath) == 0)
            {
                Console.WriteLine("file exist no need to create");
              
                sFileObj.writefile(lStrFilePath, "Ravi is a good boy\nAshu is bad boy");
                String[] linesVal = sFileObj.readFile(lStrFilePath);
                foreach(String val in linesVal)
                {
                  Console.WriteLine(val);
                }
                Console.ReadLine();
                sFileObj.deleteFile(lStrFilePath);
                Console.ReadLine();
            }
            else
            {
                if (sFileObj.createfile(lStrFilePath) ==0)
                {
                    Console.WriteLine("file created sucessfully");
                }
                else
                {
                    Console.WriteLine("file failed to create");
                }
                Console.ReadLine();
            }
        }
    }
}