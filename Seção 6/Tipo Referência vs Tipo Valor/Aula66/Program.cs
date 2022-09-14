// See https://aka.ms/new-console-template for more information

using System;
using System.Xml;

namespace Aula66
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Point p = new Point();

            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);
        }
    }
}
