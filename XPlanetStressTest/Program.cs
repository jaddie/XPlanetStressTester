using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace XPlanetStressTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Incoming CPU Ownage");
            Thread thread1 = new Thread(new ThreadStart(WhileLoop));
            thread1.Start();                                      
            Thread thread2 = new Thread(new ThreadStart(WhileLoop));
            thread2.Start();                                      
            Thread thread3 = new Thread(new ThreadStart(WhileLoop));
            thread3.Start();                                      
            Thread thread4 = new Thread(new ThreadStart(WhileLoop));
            thread4.Start();                                      
            Thread thread5 = new Thread(new ThreadStart(WhileLoop));
            thread5.Start();                                      
            Thread thread6 = new Thread(new ThreadStart(WhileLoop));
            thread6.Start();                                      
            Thread thread7 = new Thread(new ThreadStart(WhileLoop));
            thread7.Start();                                      
            Thread thread8 = new Thread(new ThreadStart(WhileLoop));
            thread8.Start();
        }
        static void WhileLoop()
        {
            while (true)
            {} // this way we keep at 100% usage, doing anything here loses a few %
        }
    }
}
