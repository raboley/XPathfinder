using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using PathFinder.Common;

namespace ConsoleApplication1
{
    internal class Program
    {


        public static void Main(string[] args)
        {


            var ffxiNav = new ffxiNav();
           
            ffxiNav.Setup();
            

            
            Console.WriteLine("Ended press a key to exit");

            Console.ReadKey();
        }
        
        
    }
}