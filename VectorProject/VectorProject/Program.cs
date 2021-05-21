using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3D aVector = new Vector3D(2, 1, 4);
            Vector3D bVector = new Vector3D(5, 2, 6);
            //float scalar = 3;

            //Vector3D result = aVector.Add(bVector);

            //Console.WriteLine(result);

            //Vector3D result2 = aVector.Add(scalar);

            //Console.WriteLine(result2);

            //Vector3D resultScale = aVector.Scale(2.0f);

            //Console.WriteLine(resultScale);

            //Vector3D resultNegate = aVector.Negate();

            //Console.WriteLine(resultNegate);

            //for (float delta = 0.0f; delta <= 1.0f; delta += 0.1f)
            //{
            //    Console.WriteLine(aVector.Lerp(bVector, delta));
            //}

            Console.WriteLine("Dot: " + aVector.Dot(bVector));
            Console.WriteLine("Cosine: " + aVector.Dot(bVector) / (aVector.Magnitude() * bVector.Magnitude()));
        }
    }
}
