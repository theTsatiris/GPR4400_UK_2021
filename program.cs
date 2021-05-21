using System;

namespace _4400Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3D aVector = new Vector3D(2, 3, 4);
            Vector3D bVector = new Vector3D(9 ,2, 5);

            Vector3D sum = aVector.Add(bVector);
            Console.WriteLine("Add " + sum.x + " " + sum.y + " " + sum.z);

            Vector3D sum2 = aVector.Add(3);
            Console.WriteLine("Subtract " + sum2.x + " " + sum2.y + " " + sum2.z);

            Vector3D mult = aVector.Scale(3);
            Console.WriteLine("Multiply " + mult.x + " " + mult.y + " " + mult.z);

            Vector3D negate = aVector.Negate();
            Console.WriteLine("negate " + negate.x + " " + negate.y + " " + negate.z);



        }
    }
}
