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

namespace TRPO_WPF_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double chis1, chis2, chis3, sum, proizv;
        int k = 0, inter1, inter2;
        bool check = false;
        Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
            TextBlo.Text = "Введите целые числа в поля. Они будут являться границами интервала генерации чисел.\n" +
                    "Затем нажмите кнопку 'Сгенерировать'. Будут сгенерированны три числа и выведенна их сумма.\n" +
                    "Чтобы посмотреть их произведение нажмите кнопку 'Произведение'. Нажмите эту кнопку ещё раз, чтобы увидеть их сумму.";
        }


        private void b1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                inter1 = Convert.ToInt32(ChisTb1.Text);
                inter2 = Convert.ToInt32(ChisTb2.Text);
                chis1 = rnd.Next(inter1, inter2);
                chis2 = rnd.Next(inter1, inter2);
                chis3 = rnd.Next(inter1, inter2);
                sum = chis1 + chis2 + chis3;
                proizv = chis1 * chis2 * chis3;
                if (k == 1)
                {
                    TextBlo.Text = "Были сгенерированны числа: " + chis1 + ", " + chis2 + ", " + chis3 + ". В промежутке от "
                    + inter1 + " до " + inter2 + ".\n Их произведение: " + proizv + ".";
                }
                
                else
                {
                    TextBlo.Text = "Были сгенерированны числа: " + chis1 + ", " + chis2 + ", " + chis3 + ". В промежутке от "
                    + inter1 + " до " + inter2 + ".\n Их сумма: " + sum + ".";
                }
                check = true;
            }
            catch (Exception)
            {
                TextBlo.Text = "Ошибка ввода:\n" +
                    "Введите целые числа в поля. Они будут являться границами интервала генерации чисел.\n" +
                    "Затем нажмите кнопку 'Сгенерировать'. Будут сгенерированны три числа и выведенна их сумма.\n" +
                    "Чтобы посмотреть их произведение нажмите кнопку 'Произведение'. Нажмите эту кнопку ещё раз, чтобы увидеть их сумму.";
            }
            
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {

            if(check)
            {
                if (k == 0)
                {
                    TextBlo.Text = "Были сгенерированны числа: " + chis1 + ", " + chis2 + ", " + chis3 + ". В промежутке от "
                    + inter1 + " до " + inter2 + ".\n Их произведение: " + proizv + ".";
                    b2.Content = "Сумма";
                    k = 1;
                }
                else
                {
                    TextBlo.Text = "Были сгенерированны числа: " + chis1 + ", " + chis2 + ", " + chis3 + ". В промежутке от "
                    + inter1 + " до " + inter2 + ".\n Их сумма: " + sum + ".";
                    b2.Content = "Произведение";
                    k = 0;
                }
            }
            else
            {
                TextBlo.Text = "Сначала вам необходимо ввести целочисленные интервалы промежутка, а затем сгенерировать числа.";
            }
            
        }
    }
}
