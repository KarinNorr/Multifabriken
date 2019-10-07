using System;

namespace Multifabriken
{
    class Pipe
    {
        public int length;
        public int diameter;
        public string material;

        
        public Pipe(int length, int diameter, string material)
        {
            this.length = length;
            this.diameter = diameter;
            this.material = material;
        }

        
        public void SetLength(int lengthInt)
        {
            length = lengthInt;
        }            
        public void SetDiameter(int diameterInt)
        {
            diameter = diameterInt;
        }            
        public void SetMaterial(string materialString)
        {
            material = materialString;
        }
        public string Content()
        {
        string str = "Typ Pipe " + " | " + "Length: "  +  length + " | " + "material: " + material+ " | " + "diameter: " + diameter;
        return str;
        }

    }
    
}
