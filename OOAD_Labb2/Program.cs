using System;
using static System.Console;
using System.Collections.Generic;

namespace OOAD_Labb2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var display = new Display(new NetworkService());
            display.Start();
        }
    }
}