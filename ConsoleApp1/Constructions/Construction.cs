using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Constructions
{
    class Construction
    {
        public Construction(double height, double width, int entrances, int humancapacity, string buildmaterial) //ctor x2tab 
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humancapacity;
            BuildMaterial = buildmaterial;

        }


        public double Height { get; set; }
        public double Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public string BuildMaterial { get; set; }
    }
}
