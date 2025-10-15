using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TriangleWorkTests
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = 0, b = 0, c = 0;

            try
            {
                if (string.IsNullOrWhiteSpace(firstBox.Text) || string.IsNullOrWhiteSpace(secondBox.Text) || string.IsNullOrWhiteSpace(thirdBox.Text))
                {
                    MessageBox.Show("У вас есть пустое поле.");
                    return;
                }

                a = int.Parse(firstBox.Text);
                b = int.Parse(secondBox.Text);
                c = int.Parse(thirdBox.Text);
                
            }
            catch (FormatException)
            {

                MessageBox.Show("Введено не целое число или символ.");
                return;
            }
            catch(OverflowException)
            {
                MessageBox.Show("Введено слишком большое и малое значение.");
                return;
            }

            if (a <= 0 || b <= 0 || c <= 0)
            {
                MessageBox.Show("У вас есть отрицательное или нулевое значение.");
                return;
            }
            else if (((a + b) > c) && ((a + c) > b) && ((b + c) > a))
            {
                if (a == b && b == c)
                {
                    itog.Text = "Треугольник равносторонний";
                }
                else if (a == b || a == c || b == c)
                {
                    itog.Text = "Треугольник равнобедренный";
                }
                
                else
                {
                    if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                    {
                        itog.Text = "Разносторонний прямоугольный треугольник";
                    }
                    else
                    {
                        itog.Text = "Разносторонний треугольник";
                    }
                }
            }
        }
    }
}
