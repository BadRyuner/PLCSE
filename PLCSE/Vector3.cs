namespace PLCSE
{
    public struct Vector3 : IComparable<Vector3>, IComparable
    {
        public Vector3(float x, float y, float z)
        {
            this.x = x; this.y = y; this.z = z;
        }

        public float x, y, z;

        public static Vector3 zero => new Vector3(0,0,0);

        public int CompareTo(Vector3 other)
        {
	        var xComparison = x.CompareTo(other.x);
	        if (xComparison != 0) return xComparison;
	        var yComparison = y.CompareTo(other.y);
	        if (yComparison != 0) return yComparison;
	        return z.CompareTo(other.z);
        }

        public int CompareTo(object? obj)
        {
	        if (obj is Vector3 vc) return CompareTo(vc); 
	        return 0;
        }
    }
}
