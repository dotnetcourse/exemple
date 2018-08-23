using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace FileOperations
{
    class Program
    {
        public static object Threa { get; private set; }

        enum TestEnum
        {
            Val1
        }

        static void Main(string[] args)
        {
            // Decomentai prima parte si comentati a doua parte,  pentru a scrie in fisier
            //string text = "mamă";

            //if (!Directory.Exists(@"c:\temp1\"))
            //{
            //    Directory.CreateDirectory(@"c:\temp1\");
            //}

            ////File.WriteAllText(@"c:\temp1\myfile.txt", text);

            //FileStream fs = File.Open(@"c:\temp1\myfile2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);

            //StreamWriter sw = new StreamWriter(fs);
            //sw.Write(true);
            //sw.Write("my text");
            //sw.Write(TestEnum.Val1);
            //sw.Flush();


            //fs.Position = 0;
            //sw.Close();
            

            FileStream fsread = File.Open(@"c:\temp1\myfile2.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fsread);
            
            while (!sr.EndOfStream)
            {
                string allText = sr.ReadLine();
                Console.WriteLine(allText);
            }
            
            Console.WriteLine("Press enter to close");
            Console.ReadLine();
        }
    }
}
