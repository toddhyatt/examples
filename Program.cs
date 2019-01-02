using System;
using System.Collections.Generic;
namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinqConsole lConsole=new LinqConsole();
            string [] listOfValues = new [] {"1-one","1-two","2-three"};
            Console.WriteLine(lConsole.RunTop(new List<string>(listOfValues)));

        }
    }
}
