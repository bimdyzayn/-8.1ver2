﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "E:\\tmp9\\";
            DirectoryInfo di = new DirectoryInfo(path);
            foreach (var papka in di.GetDirectories())
            {   
                Console.WriteLine(papka.FullName);
           
                DirectoryInfo di2 = new DirectoryInfo(path + papka.Name);
                foreach (var papka2 in di2.GetDirectories())
                {
              
                    Console.WriteLine(papka2.FullName);
                
                }
            }

            Console.ReadLine();

        }
    }
}

