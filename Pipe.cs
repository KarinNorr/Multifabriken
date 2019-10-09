using System;

namespace Multifabriken
{
    class Pipe
    {
        public int Length { get; set; }
        public int Diameter { get; set; }
        public string Material { get; set; }

        
        public Pipe(int length, int diameter, string material)
        {
            Length = length;
            Diameter = diameter;
            Material = material;
        }

        
        public void SetLength(int lengthInt)
        {
            Length = lengthInt;
        }            
        public void SetDiameter(int diameterInt)
        {
            Diameter = diameterInt;
        }            
        public void SetMaterial(string materialString)
        {
            Material = materialString;
        }
        public string Content()
        {
        string str = "Typ Pipe " + " | " + "Length: "  +  length + " | " + "material: " + material+ " | " + "diameter: " + diameter;
        return str;
        }

    }
    
}
