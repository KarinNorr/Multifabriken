using System;

namespace Multifabriken
{
    class Pipe
    {
        public int length;
            public int diameter;
            public string material;
            

            
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

    }
    
}
