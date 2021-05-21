using System;

namespace Session2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Vector3D aVector = new Vector3D(2, -3, 4);
            Vector3D bVector = new Vector3D(4, 3, 2);

            Vector3D sum = aVector.Add(bVector);
            Console.WriteLine(sum.x + " " + sum.y + " " + sum.z);

            Vector3D sum2 = aVector.Add(3);
            Console.WriteLine(sum2.x + " " + sum2.y + " " + sum2.z);

            Vector3D aScaled = aVector.Scale(2.0f);
            Console.WriteLine(aScaled.x + " " + aScaled.y + " " + aScaled.z);

            Vector3D aMirrored = aVector.Negate();
            Console.WriteLine(aMirrored.x + " " + aMirrored.y + " " + aMirrored.z);
        }

    }
}
