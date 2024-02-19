using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab3Popof
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            double sideA = Convert.ToDouble(txtSideA.Text);
            double sideB = Convert.ToDouble(txtSideB.Text);
            double sideC = Convert.ToDouble(txtSideC.Text);
            double angleA = Convert.ToDouble(txtAngleA.Text);
            double angleB = Convert.ToDouble(txtAngleB.Text);
            double angleC = Convert.ToDouble(txtAngleC.Text);

            Triangle triangle = new Triangle(sideA, sideB, sideC, angleA, angleB, angleC);

            double area = triangle.CalcArea();
            double perimeter = triangle.CalcPerimetr();
            double height = triangle.CalcHeight();
            string type = triangle.TriangleType();

            Result.Content = $"Площадь: {area}, Периметр: {perimeter}, Высота: {height}, Тип треугольника: {type}";
        }
    }
}