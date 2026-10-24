using System;
namespace Lab_rab_KalyamovaE.A_BPI_24_01_Part2
{
    public class Ellipse : GeometricShape
    {
        ///большая полуось эллипса
        public double MajorAxis { get; set; }
        ///малая полуось эллипса
        public double MinorAxis { get; set; }
        ///вызов конструктора родителя через base.
        public Ellipse(double a, double b) : base("эллипс")
        {
            MajorAxis = a;
            MinorAxis = b;
        }
        ///площадь эллипса
        public override double GetArea()
        {
            return Math.PI * MajorAxis * MinorAxis;
        }
        ///периметр эллипса
        public override double GetPerimeter()
        {
            double a = MajorAxis;
            double b = MinorAxis;
            return Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b)));
        }
        ///переопределение PrintInfo
        public override void PrintInfo()
        {
            Console.WriteLine($"эллипс: a = {MajorAxis}, b = {MinorAxis}, S = {GetArea():F2}, P = {GetPerimeter():F2}");
        }
        ///перегрузка PrintInfo
        public void PrintInfo(string prefix)
        {
            Console.WriteLine($"{prefix} эллипс: a = {MajorAxis}, b = {MinorAxis}, S = {GetArea():F2}, P = {GetPerimeter():F2}");
        }
    }
}