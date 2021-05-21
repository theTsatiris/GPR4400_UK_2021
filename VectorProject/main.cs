using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3D aVector = new Vector3D(2, 3, 4);
            Vector3D bVector = new Vector3D(4, 3, 2);

            Vector3D sum = aVector.Add(bVector);
            Console.WriteLine("VECTOR ADDITION: "+sum.x + " " + sum.y + " " +sum.z);

            Vector3D sum2 = aVector.Add(3);
            Console.WriteLine("SCALAR ADDITION: "+sum2.x + " " + sum2.y + " " + sum2.z);

            Vector3D aMultiply = aVector.Multiply(2.0f);
            Console.WriteLine("SCALING: "+aMultiply.x + " " + aMultiply.y + " " + aMultiply.z);
            
            Vector3D aMirrored = aVector.Negate();
            Console.WriteLine("MIRRORING: "+aMirrored.x + " " + aMirrored.y + " " + aMirrored.z);

            //sum2.x = 5.4f;
        }
    }
   
}
