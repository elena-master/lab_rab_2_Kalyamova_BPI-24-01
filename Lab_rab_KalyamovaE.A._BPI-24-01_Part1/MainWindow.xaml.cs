using System;
using System.Windows;
using System.Windows.Input;
namespace Lab_rab_KalyamovaE.A._BPI_24_01_Part1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /// для оклада разрешает только цифры и точку
        private void NumberOnly_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!int.TryParse(e.Text, out _) && e.Text != ".")
                e.Handled = true;
        }
        ///для даты разрешает только цифры и точку
        private void DateOnly_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!int.TryParse(e.Text, out _) && e.Text != ".")
                e.Handled = true;
        }
        ///запрещает пробел
        private void NoSpace_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }
        //обработчик кнопок
        private void BtnAge_Click(object sender, RoutedEventArgs e)
        {
            if (!TryReadWorker(out Worker w))
                return;

            TbResult.Text = $"Возраст работника {w.Surname}: {w.GetAge()} лет";
        }
        private void BtnDays50_Click(object sender, RoutedEventArgs e)
        {
            if (!TryReadWorker(out Worker w))
                return;

            TbResult.Text = $"До 50 лет работнику {w.Surname}: {w.DaysUntil50()} дн.";
        }
        //чтение и проверка данных
        private bool TryReadWorker(out Worker worker)
        {
            worker = null;
            if (string.IsNullOrWhiteSpace(TbSurname.Text))
            {
                MessageBox.Show("Введите фамилию!", "Ошибка",
                                MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            if (!double.TryParse(TbSalary.Text, out double salary))
            {
                MessageBox.Show("Некорректный оклад! Введите число.",
                                "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            if (!DateTime.TryParse(TbBirthDate.Text, out DateTime birth))
            {
                MessageBox.Show("Некорректная дата рождения! Формат: дд.мм.гггг",
                                "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            try
            {
                worker = new Worker(TbSurname.Text, salary, birth);
                return true;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                                MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
        }
    }
}
