using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        ArrayList Beowulf;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
        }
        public void Run() { this.ReadTextFiles(); }

        public void ReadTextFiles()
        {
            //Read file using streamReader. reads file line by line
            using (StreamReader file = new StreamReader("c:/area51/beowulf.txt"))
            {
                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    Console.Writeline(ln);
                    Beowulf.Add(ln);
                }
                file.Console();
                Console.WriteLine($"File has {counter} lines.");
            }
            }
        public int FindNumberOfBlankSpace(string line)
        {
            //https://strackoverflow.com/questions/17812566/count-words-spaces-in-string-c-sharp
        }
        }
    }
}
