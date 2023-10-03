using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Vectors
{
    public class Vector
    {
        double Xdirection;
        double Ydirection;
        public Vector(double x, double y)
        {
            Xdirection = x;
            Ydirection = y;
        }
        public Vector Multiply(double scalar)
        {
            Xdirection *= scalar;
            Ydirection *= scalar;
            return new Vector(Xdirection, Ydirection);
        }
        public double Magnitude()
        {
            return Math.Sqrt(Math.Pow(Xdirection, 2) + Math.Pow(Ydirection, 2));
        }
        public Vector Add(Vector vector2)
        {
            return new Vector(Xdirection + vector2.Xdirection, Ydirection + vector2.Ydirection);
        }
        public double DotProduct(Vector vector2)
        {
            return (Xdirection * vector2.Xdirection + Ydirection * vector2.Ydirection);
        }
        public double anglebetween(Vector vector2)
        {
            return Math.Acos(this.DotProduct(vector2) / (this.Magnitude() * vector2.Magnitude()));
        }

    }
}
