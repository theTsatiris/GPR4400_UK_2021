using System;
using System.Collections.Generic;
using System.Text;

namespace Session2
{
    class Vector3D
    {
        public float x;
        public float y;
        public float z;

        public Vector3D(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3D()
        {
            this.x = 0.0f;
            this.y = 0.0f;
            this.z = 0.0f;
        }

        public Vector3D Add(Vector3D b)
        {
            Vector3D result = new Vector3D();

            result.x = this.x + b.x;
            result.y = this.y + b.y;
            result.z = this.z + b.z;

            return result;
        }

        public Vector3D Add(float scalar)
        {
            Vector3D result = new Vector3D();

            result.x = this.x + scalar;
            result.y = this.y + scalar;
            result.z = this.z + scalar;

            return result;
        }

        public Vector3D Subtract(Vector3D b)
        {
            Vector3D result = new Vector3D();

            result.x = this.x - b.x;
            result.y = this.y - b.y;
            result.z = this.z - b.z;

            return result;
        }

        public Vector3D Subtract(float scalar)
        {
            Vector3D result = new Vector3D();

            result.x = this.x - scalar;
            result.y = this.y - scalar;
            result.z = this.z - scalar;

            return result;
        }

        public Vector3D Scale(float factor)
        {
            Vector3D result = new Vector3D();

            result.x = this.x * factor;
            result.y = this.y * factor;
            result.z = this.z * factor;

            return result;
        }

        public Vector3D Negate()
        {
            Vector3D result = new Vector3D();

            result.x = -this.x;
            result.y = -this.y;
            result.z = -this.z;

            return result;
        }

        public void Normalize()
        {
            double mag = this.Magnitude();
            this.x /= (float)mag; 
            this.y /= (float)mag; 
            this.z /= (float)mag;
        }

        public double Magnitude()
        {
            double length = 0.0f;

            length = Math.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);

            return length;
        }

        public Vector3D LERP(Vector3D dst, float delta)
        {
            Vector3D result = new Vector3D();

            if((delta < 0.0f) || (delta > 1.0f))
            {
                Console.WriteLine("INVALID DELTA");
                return result;
            }

            result.x = ((1 - delta) * this.x) + (delta * dst.x);
            result.y = ((1 - delta) * this.y) + (delta * dst.y);
            result.z = ((1 - delta) * this.z) + (delta * dst.z);

            return result;
        }

        public double Dot(Vector3D b)
        {
            double result = 0.0f;

            result = (this.x * b.x) + (this.y * b.y) + (this.z * b.z);

            return result;
        }
    }
}
