class Quaternion
{
    private double w;
    private double x;
    private double y;
    private double z;

    public double W
    {
        get { return w; }
        set { w = value; }
    }
    public double X
    {
        get { return x; }
        set { x = value; }
    }
    public double Y
    {
        get { return y;}
        set { y = value; }
    }
    public double Z
    {
        get { return z; }
        set { z = value; }
    }
    public override string ToString()
    {
        return $"{W} + {X}i + {Y}j + {Z}k";
    }

    public Quaternion(double w, double x, double y, double z)
    {
        W = w; X = x; Y = y; Z = z;
    }

    public static bool operator==(Quaternion q, Quaternion p)
    {
        if(q.W == p.W && q.X == p.X && q.Y == p.Y && q.Z == p.Z)
        {
            return true;
        }
        else { return false; }
    }
    public static bool operator !=(Quaternion q, Quaternion p)
    {
        if (q.W != p.W && q.X != p.X && q.Y != p.Y && q.Z != p.Z)
        {
            return true;
        }
        else { return false; }
    }
    public static Quaternion operator+(Quaternion q, Quaternion p)
    {
        return new Quaternion(q.W+p.W, q.X+p.X, q.Y+p.Y, q.Z+p.Z);
    }
    public static Quaternion operator -(Quaternion q, Quaternion p)
    {
        return new Quaternion(q.W - p.W, q.X - p.X, q.Y - p.Y, q.Z - p.Z);
    }
    public static Quaternion operator *(Quaternion q, Quaternion p)
    {
        double w = q.W * p.W - q.X * p.X - q.Y * p.Y - q.Z * p.Z;
        double x = q.W * p.X + q.X * p.W + q.Y * p.Z - q.Z * p.Y;
        double y = q.W * p.Y - q.X * p.Z + q.Y * p.W + q.Z * p.X;
        double z = q.W * p.Z + q.X * p.Y - q.Y * p.X + q.Z * p.W;

        return new Quaternion(w, x, y, z);
    }
    public static Quaternion operator /(Quaternion q, Quaternion p)
    {
        return q * p.InverseDivision();
    }
    public Quaternion InverseDivision()
    {
        double normSq = W * W + X * X + Y * Y + Z * Z;
        return new Quaternion(W / normSq, -X / normSq, -Y / normSq, -Z / normSq);
    }
    public double Norm()
    {
        return Math.Sqrt(W*W + X*X + Y*Y + Z*Z);
    }
    public Quaternion Conjugate()
    {
        return new Quaternion(W, -X, -Y, -Z);
    }
    public Quaternion Inverse()
    {
        double normSq = Norm() * Norm();
        return new Quaternion(W / normSq, -X / normSq, -Y / normSq, -Z / normSq);
    }
    public double[,] ToRotationMatrix()
    {
        double norm = Norm();
        double s = norm > 0 ? 2.0 / norm : 0;

        double wx = s * W * X;
        double wy = s * W * Y;
        double wz = s * W * Z;
        double xx = s * X * X;
        double xy = s * X * Y;
        double xz = s * X * Z;
        double yy = s * Y * Y;
        double yz = s * Y * Z;
        double zz = s * Z * Z;

        return new double[,]
        {
            { 1 - (yy + zz), xy - wz, xz + wy },
            { xy + wz, 1 - (xx + zz), yz - wx },
            { xz - wy, yz + wx, 1 - (xx + yy) }
        };
    }
    public static Quaternion FromRotationMatrix(double[,] matrix)
    {
        double trace = matrix[0, 0] + matrix[1, 1] + matrix[2, 2];
        double s;

        if (trace > 0)
        {
            s = 0.5 / Math.Sqrt(trace + 1.0);
            return new Quaternion(
                0.25 / s,
                (matrix[2, 1] - matrix[1, 2]) * s,
                (matrix[0, 2] - matrix[2, 0]) * s,
                (matrix[1, 0] - matrix[0, 1]) * s
            );
        }
        else if (matrix[0, 0] > matrix[1, 1] && matrix[0, 0] > matrix[2, 2])
        {
            s = 2.0 * Math.Sqrt(1.0 + matrix[0, 0] - matrix[1, 1] - matrix[2, 2]);
            return new Quaternion(
                (matrix[2, 1] - matrix[1, 2]) / s,
                0.25 * s,
                (matrix[0, 1] + matrix[1, 0]) / s,
                (matrix[0, 2] + matrix[2, 0]) / s
            );
        }
        else if (matrix[1, 1] > matrix[2, 2])
        {
            s = 2.0 * Math.Sqrt(1.0 + matrix[1, 1] - matrix[0, 0] - matrix[2, 2]);
            return new Quaternion(
                (matrix[0, 2] - matrix[2, 0]) / s,
                (matrix[0, 1] + matrix[1, 0]) / s,
                0.25 * s,
                (matrix[1, 2] + matrix[2, 1]) / s
            );
        }
        else
        {
            s = 2.0 * Math.Sqrt(1.0 + matrix[2, 2] - matrix[0, 0] - matrix[1, 1]);
            return new Quaternion(
                (matrix[1, 0] - matrix[0, 1]) / s,
                (matrix[0, 2] + matrix[2, 0]) / s,
                (matrix[1, 2] + matrix[2, 1]) / s,
                0.25 * s
            );
        }
    }
}
