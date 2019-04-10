﻿using System;
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
            p.ReadTextFiles();
        }
        public void Run() { this.ReadTextFiles(); }

        public void ReadTextFiles()
        {
           
            using (StreamReader file = new StreamReader(@"U:\Users\727466\beowulf.txt"))
            {
                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    counter++;
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines. ");
            }
        }
        public int FindNumberOfBlankSpace(string line)
        {
            
            int countletters = 0;
            int countSpaces = 0;

            foreach (Char c in line)
            {
                if (char.IsLetter(c)) { countletters++; }
                if (char.IsWhiteSpace(c)) { countSpaces++; }
            }
            return countSpaces;
        }
    }

}
