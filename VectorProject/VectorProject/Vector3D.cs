using System;
using System.Collections.Generic;
using System.Text;

namespace Vector_Task_1
{
    class Vector3D
    {
        private float x, y, z;

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

        public Vector3D Add(float value)
        {
            Vector3D result = new Vector3D();

            result.x = this.x + value;
            result.x = this.y + value;
            result.x = this.z + value;

            return result;
        }

        public Vector3D Subtract(float value)
        {
            Vector3D result = new Vector3D();

            result.x = this.x - value;
            result.x = this.y - value;
            result.x = this.z - value;

            return result;
        }

        public Vector3D Scale(float value)
        {
            Vector3D result = new Vector3D();

            result.x = this.x * value;
            result.x = this.y * value;
            result.x = this.z * value;

            return result;
        }

        public Vector3D Negate()
        {
            Vector3D result = new Vector3D();

            result.x = -this.x;
            result.x = -this.y;
            result.x = -this.z;

            return result;
        }
    }
}
