using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Vector3D
    {
        private float x, y, z;

        public float getX()
        {
            return x;
        }

        public float getY()
        {
            return y;
        }
        public float getZ()
        {
            return z;
        }

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

        public Vector3D Add(Vector3D other)
        {
            Vector3D result = new Vector3D();

            result.x = this.x + other.getX();
            result.y = this.y + other.getY();
            result.z = this.z + other.getZ();

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

        public Vector3D Subtract(Vector3D other)
        {
            Vector3D result = new Vector3D();

            result.x = this.x - other.getX();
            result.y = this.y - other.getY();
            result.z = this.z - other.getZ();

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

        public void Normalise()
        {
            float magnitude = this.Magnitude();
            this.x /= magnitude;
            this.y /= magnitude;
            this.z /= magnitude;
        }

        public Vector3D Lerp(Vector3D dst, float delta)
        {
            Vector3D result = new Vector3D();

            if (delta < 0.0f || delta > 1.0f)
            {
                Console.WriteLine("Invalid delta");
                return result;
            }

            result = this.Scale(1 - delta).Add(dst.Scale(delta));

            return result;
        }

        public float Magnitude()
        {
            return (float)Math.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
        }

        public float Dot(Vector3D bVector)
        {
            return this.x * bVector.getX() + this.y * bVector.getY() + this.z * bVector.getZ();
        }

        public override string ToString()
        {
            return "Vector3D: " + this.x + " " + this.y + " " + this.z;
        }
    }
}
