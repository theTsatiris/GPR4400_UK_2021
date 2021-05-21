namespace ConsoleApplication1
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
//              ADDITION FUNCITON
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
//            SUBTRACTION FUNCTION
        public Vector3D Sub(Vector3D b)
        {
            Vector3D result = new Vector3D();

            result.x = this.x - b.x;
            result.y = this.y - b.y;
            result.z = this.z - b.z;
            return result;
        }
        public Vector3D Sub(float scalar)
        {
            Vector3D result = new Vector3D();

            result.x = this.x - scalar;
            result.y = this.y - scalar;
            result.z = this.z - scalar;
            return result;
        }
        public Vector3D Multiply(float factor)
        {
            Vector3D result = new Vector3D();

            result.x = this.x *factor;
            result.y = this.y *factor;
            result.z = this.z *factor;
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
        
    }
}
