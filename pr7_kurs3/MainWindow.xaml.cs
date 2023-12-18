/*
Использовать класс Triad (тройка чисел). Определить производный класс Date с 
полями: год, месяц и день. Переопределить методы увеличения полей на 1 и 
определить метод увеличения даты на n дней.
*/
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

namespace pr7_kurs3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int aa = Convert.ToInt32(A_TB.Text);
            int bb = Convert.ToInt32(B_TB.Text);
            int cc = Convert.ToInt32(C_TB.Text);
            Triad incrabc = new Triad(aa++, bb, cc);
            
            
        }
    }
}
