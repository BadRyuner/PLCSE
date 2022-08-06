namespace PLCSE
{
    public struct Vector3
    {
        public Vector3(float x, float y, float z)
        {
            this.x = x; this.y = y; this.z = z;
        }

        public float x, y, z;

        public static Vector3 zero => new Vector3(0,0,0);
    }
}
