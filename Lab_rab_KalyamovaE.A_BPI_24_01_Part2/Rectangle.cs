using System;
namespace Lab_rab_KalyamovaE.A_BPI_24_01_Part2
{
    public class Rectangle : GeometricShape
    {
        ///длина стороны прямоугольника
        public double Width { get; set; }
        ///ширина стороны прямоугольника
        public double Height { get; set; }

        ///вызов конструктора родителя через base
        public Rectangle(double width, double height) : base("прямоугольник")
        {
            Width = width;
            Height = height;
        }
        ///площадь прямоугольника
        public override double GetArea()
        {
            return Width * Height;
        }
        ///периметр прямоугольника
        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
