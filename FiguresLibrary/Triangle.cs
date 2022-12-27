using System.Drawing;

namespace FiguresLibrary
{
    public class Triangle : Polygon
    {
        public Triangle(int id, Point[] points) : base(id, points)
        {
            name = "Треугольник";
        }
    }
}