using System;

namespace Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3D aVector = new Vector3D(2, 3, 4);
            Vector3D bVector = new Vector3D(4, 3, 2);

            Vector3D sum = aVector.add(bVector);
            Vector3D sum2 = aVector.add(3);
            Vector3D aScaled = aVector.scale(2.0f);

            Console.WriteLine(sum.x + " " + sum.y + " " + sum.z);
            Console.WriteLine(sum2.x + " " + sum2.y + " " + sum2.z);
        }
    }
}
