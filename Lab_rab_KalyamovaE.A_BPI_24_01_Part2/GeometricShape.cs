using System;
namespace Lab_rab_KalyamovaE.A_BPI_24_01_Part2
{
    ///реализует интерфейс IShape2D
    public abstract class GeometricShape : IShape2D
    {
        ///название фигуры
        public string Name { get; set; }
        ///вызов конструктора через base
        protected GeometricShape(string name)
        {
            Name = name;
        }
        ///вычисление площади
        public abstract double GetArea();
        ///вычисление периметра
        public abstract double GetPerimeter();
        ///получение подробной информации о фигуре
        public virtual string GetDetails()
        {
            return $"геометрическая фигура: {Name}";
        }
        ///вывод информации в консоль
        public virtual void PrintInfo()
        {
            Console.WriteLine($"информация о фигуре: {Name}");
        }
    }
}
