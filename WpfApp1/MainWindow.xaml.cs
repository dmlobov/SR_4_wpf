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

namespace Ex_1
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
            double rateDollar = Convert.ToDouble(rate1.Text);
            double sumDollar = Convert.ToDouble(sum1.Text);
            double resDouble = rateDollar * sumDollar;
            resSum1.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEvro = Convert.ToDouble(rate2.Text);
            double sumEvro = Convert.ToDouble(sum2.Text);
            double resDouble = rateEvro * sumEvro;
            resSum2.Text = resDouble.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGriv = Convert.ToDouble(rate3.Text);
            double sumGriv = Convert.ToDouble(sum3.Text);
            double resDouble = rateGriv * sumGriv;
            resSum3.Text = resDouble.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(rate4.Text);
            double sumDram = Convert.ToDouble(sum4.Text);
            double resDouble = rateDram * sumDram;
            resSum4.Text = resDouble.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double lineDuim = Convert.ToDouble(line1.Text);
            double resLine = lineDuim * 0.0254;
            resLine1.Text = resLine.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double lineFut = Convert.ToDouble(line2.Text);
            double resLine = lineFut * 0.3048;
            resLine2.Text = resLine.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double lineMili = Convert.ToDouble(line3.Text);
            double resLine = lineMili * 1609.34;
            resLine3.Text = resLine.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double lineVerst = Convert.ToDouble(line4.Text);
            double resLine = lineVerst * 1066.8;
            resLine4.Text = resLine.ToString();
        }
    }
}