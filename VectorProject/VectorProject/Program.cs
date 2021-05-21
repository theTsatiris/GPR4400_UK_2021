using System;

namespace Session2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Vector3D aVector = new Vector3D(2, 3, 4);
            Vector3D bVector = new Vector3D(6, 3, 2);
            
            Vector3D vectorSum = aVector.Add(bVector);
            Console.WriteLine("Vector Sum: " + vectorSum.x + " " + vectorSum.y + " " + vectorSum.z);

            Vector3D scalarSum = aVector.Add(3);
            Console.WriteLine("Scalar Sum: " + scalarSum.x + " " + scalarSum.y + " " + scalarSum.z);

            Vector3D aScaled = aVector.Scale(2.0f);
            Console.WriteLine("Scaled Vector: " + aScaled.x + " " + aScaled.y + " " + aScaled.z);

            Vector3D aMirrored = aVector.Negate();
            Console.WriteLine("Mirrored Vector: " + aMirrored.x + " " + aMirrored.y + " " + aMirrored.z);
                        
            for (float delta = 0.0f; delta <= 1.0f; delta += 0.1f)
            {
                Console.WriteLine("We are at point " + aVector.LERP(bVector, delta));
               
            }
            
            aVector.Normalize();
            bVector.Normalize();

            Console.WriteLine("Dot Product: " + aVector.Dot(bVector));
            Console.WriteLine("Cosine: " + aVector.Dot(bVector) / (aVector.Magnitude() * (bVector.Magnitude())));
        }
    }
}
