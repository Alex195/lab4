﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

namespace ConsoleApp5
{

        
            class Program
            {
                static void Main(string[] args)
                {
                    var assembly = Assembly.GetExecutingAssembly();
                    var fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
                    var version = fileVersionInfo.ProductVersion;
                    Console.Write(fileVersionInfo);
            Console.Write("1.523155r");
                         
                    Console.ReadLine();
    
                }

            }
}
