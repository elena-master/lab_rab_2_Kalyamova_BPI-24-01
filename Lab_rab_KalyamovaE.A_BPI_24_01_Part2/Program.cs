using System;
using System.Globalization;
namespace Lab_rab_KalyamovaE.A_BPI_24_01_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ромб
            double rD1 = ReadPositiveDouble("введите первую диагональ ромба: ");
            double rD2 = ReadPositiveDouble("введите вторую диагональ ромба: ");
            Console.WriteLine();
            //прямоугольник
            double rectW = ReadPositiveDouble("введите ширину прямоугольника: ");
            double rectH = ReadPositiveDouble("введите высоту прямоугольника: ");
            Console.WriteLine();
            //эллипс
            double eA = ReadPositiveDouble("введите большую полуось эллипса: ");
            double eB = ReadPositiveDouble("введите малую полуось эллипса: ");
            Console.WriteLine();

            //создание экземпляров классов
            GeometricShape[] shapes =
            {
                new Rhombus(rD1, rD2),
                new Rectangle(rectW, rectH),
                new Ellipse(eA, eB)
            };
            Console.WriteLine("результаты вычислений\n");
            //демонстрация работы 
            foreach (var shape in shapes)
            {
                //GetDetails
                Console.WriteLine(shape.GetDetails());
                //IShape2D
                Console.WriteLine($"площадь: {shape.GetArea():F2}");
                Console.WriteLine($"периметр: {shape.GetPerimeter():F2}");
                //PrintInfo для Ellipse
                if (shape is Ellipse ellipse)
                {
                    ellipse.PrintInfo();                     
                    ellipse.PrintInfo("доп. информация");    
                }
                else
                {
                    shape.PrintInfo();                       
                }
            }
            Console.ReadKey();
        }
        ///проверка безопасного ввода положительного числа
        private static double ReadPositiveDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (double.TryParse(input.Replace('.', ','), NumberStyles.Any, CultureInfo.CurrentCulture, out double value) && value > 0)
                {
                    return value;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ошибка!введите положительное число!!");
                Console.ResetColor();
            }
        }
    }
}
