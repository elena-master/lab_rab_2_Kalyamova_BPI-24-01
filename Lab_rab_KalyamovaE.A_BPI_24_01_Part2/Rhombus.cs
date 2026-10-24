using System;
namespace Lab_rab_KalyamovaE.A_BPI_24_01_Part2
{
    public class Rhombus : GeometricShape
    {
        ///длина первой диагонали ромба
        public double Diagonal1 { get; set; }
        ///длина второй диагонали ромба
        public double Diagonal2 { get; set; }
        ///вызов конструктора родителя через base
        public Rhombus(double d1, double d2) : base("ромб")
        {
            Diagonal1 = d1;
            Diagonal2 = d2;
        }
        ///сторона ромба
        private double Side => Math.Sqrt(Math.Pow(Diagonal1 / 2, 2) + Math.Pow(Diagonal2 / 2, 2));
        ///площадь ромба
        public override double GetArea()
        {
            return (Diagonal1 * Diagonal2) / 2;
        }
        ///периметр ромба
        public override double GetPerimeter()
        {
            return 4 * Side;
        }
        ///переопределение GetDetails
        public override string GetDetails()
        {
            return base.GetDetails() + $", диагонали: {Diagonal1} и {Diagonal2}";
        }
        ///переопределение PrintInfo
        public override void PrintInfo()
        {
            Console.WriteLine($"ромб: d1 = {Diagonal1}, d2 = {Diagonal2}, S = {GetArea():F2}, P = {GetPerimeter():F2}");
        }
    }
}
