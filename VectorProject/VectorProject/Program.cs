using System;

namespace Vector_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3D aVector = new Vector3D(2, 6, 12);
            Vector3D bVector = new Vector3D(3, 5, 7);
            float value = 2;

            Vector3D resultAdd = aVector.Add(value);
            Console.WriteLine("Vector3D Values: " + resultAdd);

            Vector3D resultSubtract = aVector.Subtract(value);
            Console.WriteLine("Vector3D Values: " + resultSubtract);

            Vector3D resultScale = aVector.Scale(value);
            Console.WriteLine("Vector3D Values: " + resultScale);

            Vector3D resultNegate = aVector.Negate();
            Console.WriteLine("Vector3D Values: " + resultNegate);
        }
    }
}
