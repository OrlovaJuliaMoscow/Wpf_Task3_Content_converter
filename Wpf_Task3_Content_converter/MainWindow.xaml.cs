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

namespace Wpf_Task3_Content_converter
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
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rate1Dollar = Convert.ToDouble(rate1.Text);
            double sum1Dollar = Convert.ToDouble(sum1.Text);
            double res1Double = rate1Dollar * sum1Dollar;
            resSum1.Text = res1Double.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rate2Dollar = Convert.ToDouble(rate2.Text);
            double sum2Dollar = Convert.ToDouble(sum2.Text);
            double res2Double = rate2Dollar * sum2Dollar;
            resSum2.Text = res2Double.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rate3Dollar = Convert.ToDouble(rate3.Text);
            double sum3Dollar = Convert.ToDouble(sum3.Text);
            double res3Double = rate3Dollar * sum3Dollar;
            resSum3.Text = res3Double.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
           int sum4Dollar = Convert.ToInt32(sum4.Text);
            int res4Int=(sum4Dollar*254 / 10000);
            resSum4.Text = res4Int.ToString("F3");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int sum5Dollar = Convert.ToInt32(sum5.Text);
            int res5Int = (sum5Dollar * 3048 / 100000);
            resSum5.Text = res5Int.ToString("F3");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            int sum6Dollar = Convert.ToInt32(sum6.Text);
            int res6Int = (sum6Dollar * 1609344/ 1000);
            resSum6.Text = res6Int.ToString("F3");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            int sum7Dollar = Convert.ToInt32(sum7.Text);
            int res7Int = (sum7Dollar * 10668 / 10);
            resSum7.Text = res7Int.ToString("F3");
        }
    }
}
