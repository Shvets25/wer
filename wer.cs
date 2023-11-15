using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    enum Color 
    {
        Red,
        Green,
        Yellow,
        Blue
        
    }
    
    class Point
    {
        public int x;

        public int y;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.x = 4;
            p.y = 2;
            Console.WriteLine(p.x);
            Console.WriteLine(p.y);
        }
    }
    
}
