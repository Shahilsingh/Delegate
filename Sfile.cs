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
    class Sfile
    {

        private int  SUCCESS = 0;
        private int  FAILED = 1;
        public int createfile(String pfileName)
        {
                try
                {
                    File.Create(pfileName);
                    return SUCCESS;
                }
                catch(Exception e)
                {
                  Console.WriteLine (e.Message);

                    return FAILED;
                }
           
         
        }
        public void writefile(String pfileName, String pValue)
        {
            
            TextWriter tw = new StreamWriter(pfileName);
            try
            {

                tw.WriteLine(pValue);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
             
            }
            tw.Close();
            Console.WriteLine("file written close sucessfully");
         
        }
        public String [] readFile(String pfileName)
        {
            String[] lines;
            lines = File.ReadAllLines(pfileName);   
            return lines;
        }
        
        public void deleteFile(String pfileName)
        {
            File.Delete(pfileName);
            Console.WriteLine("file deleted sucessfully");
        }

        public int isFileExit(String pfileName)
        {
            if (File.Exists(pfileName))
            {
                Console.WriteLine("File Exists");
                return SUCCESS;
            }
            return FAILED;
        }

    }
}
