using System;
using ConsoleApp1.Constructions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var construction = new Construction(13, 45, 4, 6, "brick");
            Console.WriteLine(construction.BuildMaterial);
        }
    }
}
